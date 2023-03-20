using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;
using Microsoft.IdentityModel.Tokens;
using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Enum;
using Villa.Domain.Settings;
using Villa.Service.Contract;
using Villa.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Villa.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Dtos;

namespace Villa.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailService _emailService;
        private readonly JWTSettings _jwtSettings;
        private readonly IDateTimeService _dateTimeService;
        private readonly IFeatureManager _featureManager;
        private IAppDbContext appDbContext;
        public AccountService(UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<JWTSettings> jwtSettings,
            IDateTimeService dateTimeService,
            SignInManager<User> signInManager,
            IAppDbContext appDbContext,
            IEmailService emailService,
            IFeatureManager featureManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtSettings = jwtSettings.Value;
            _dateTimeService = dateTimeService;
            _signInManager = signInManager;
            this.appDbContext = appDbContext;
            _emailService = emailService;
            _featureManager = featureManager;
        }

        public async Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress)
        {
            var user = await _userManager.FindByEmailAsync(request.UserName);
            if (user == null)
            {
                throw new ApiException($"No Accounts Registered with {request.UserName}.");
            }
           
            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                throw new ApiException($"Invalid Credentials for '{request.UserName}'.");
            }
            // if (!user.EmailConfirmed)
            // {
            //     throw new ApiException($"Account Not Confirmed for '{request.Email}'.");
            // }

            JwtSecurityToken jwtSecurityToken = await GenerateJWToken(user);

            AuthenticationResponse response = new AuthenticationResponse();
            response.Id = user.Id;
            response.JWToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            response.UserName = user.UserName;
            response.Image = user.Image; 

            var rolesList = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
            response.Roles = rolesList.ToList();

            var refreshToken = GenerateRefreshToken(ipAddress);
            response.RefreshToken = refreshToken.Token;

            return new Response<AuthenticationResponse>(response, $"Authenticated {user.UserName}");
        }

        public async Task<Response<string>> RegisterAsync(RegisterRequest request, string origin)
        {
            var userWithSameUserName = await _userManager.FindByNameAsync(request.UserName);
            if (userWithSameUserName != null)
            {
                throw new ApiException($"Kullanıcı Adı '{request.UserName}' başka bir kullanıcı tarafından kaydediliyor.");
            }

            var user = new User
            {
                UserName = request.UserName,
                Ad = request.Ad,
                Soyad = request.Soyad,
                Email = request.Email,
                Image = request.Image,
                TelefonGSM = request.TelefonGSM
            };

            var userWithSameEmail = await _userManager.FindByNameAsync(request.UserName);
            if (userWithSameEmail == null)
            {
                var result = await _userManager.CreateAsync(user, request.Password);
                if (result.Succeeded)
                {
                    if (!await _userManager.IsInRoleAsync(user, request.RoleName))
                    {
                        var userResult = await _userManager.AddToRoleAsync(user, request.RoleName.ToUpper());

                        var role = await _roleManager.FindByNameAsync(request.RoleName);
                        var permissionroles = appDbContext.RoleClaims.ToList().FindAll(x => x.RoleId == role.Id);
                        foreach (IdentityRoleClaim<string> uvm in permissionroles)
                        {
                            appDbContext.UserClaims.Add(new IdentityUserClaim<string>
                            {
                                UserId = user.Id,
                                ClaimValue = uvm.ClaimValue,
                                ClaimType = "permission"
                            });
                        }
                        appDbContext.SaveChangesAsync();
                    }

                }
            }
            return new Response<string>(user.Id, message: $"User Registered.");
        }


        private async Task<JwtSecurityToken> GenerateJWToken(User user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim("roles", roles[i]));
            }

            string ipAddress = IpHelper.GetIpAddress();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id),
                new Claim("ip", ipAddress)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        private string RandomTokenString()
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            var randomBytes = new byte[40];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            // convert random bytes to hex string
            return BitConverter.ToString(randomBytes).Replace("-", "");
        }

        private async Task<string> SendVerificationEmail(User user, string origin)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var route = "api/account/confirm-email/";
            var _enpointUri = new Uri(string.Concat($"{origin}/", route));
            var verificationUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "userId", user.Id);
            verificationUri = QueryHelpers.AddQueryString(verificationUri, "code", code);
            //Email Service Call Here
            return verificationUri;
        }

        public async Task<Response<string>> ConfirmEmailAsync(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return new Response<string>(user.Id, message: $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.");
            }
            else
            {
                throw new ApiException($"An error occured while confirming {user.Email}.");
            }
        }

        private RefreshToken GenerateRefreshToken(string ipAddress)
        {
            return new RefreshToken
            {
                Token = RandomTokenString(),
                Expires = DateTime.UtcNow.AddDays(7),
                Created = DateTime.UtcNow,
                CreatedByIp = ipAddress
            };
        }

        public async Task ForgotPassword(ForgotPasswordRequest model, string origin)
        {
            var account = await _userManager.FindByEmailAsync(model.Email);

            // always return ok response to prevent email enumeration
            if (account == null) return;

            var code = await _userManager.GeneratePasswordResetTokenAsync(account);
            var route = "api/account/reset-password/";
            var _enpointUri = new Uri(string.Concat($"{origin}/", route));
            var emailRequest = new MailRequest()
            {
                Body = $"You reset token is - {code}",
                ToEmail = model.Email,
                Subject = "Reset Password",
            };
            await _emailService.SendEmailAsync(emailRequest);
        }
        
        
        public async Task<ResponseModel> GetAllAsync()
        {
            // var usersDto = _mapper.Map<List<UserInformationDto>>(_userManager.Users.Include(x=> x.UserRole).ToListAsync());
            var usersDto = await _userManager.Users
                //.Include(y => y.UserRole)
                .Select( x => new UserInformationDto()
                {
                    Id = x.Id,
                    Name = x.Ad,
                    SurName = x.Soyad,
                    Email = x.Email,
                    Image = x.Image,
                    Role = "SistemAmin",
                    //Role = _roleManager. .Where(b=> b.Id == x. .UserRole.FirstOrDefault().RoleId).FirstOrDefault().NormalizedName
                })
                .ToListAsync();

            return new ResponseModel(usersDto);
        }

        public async Task<Response<string>> ResetPassword(ResetPasswordRequest model)
        {
            var account = await _userManager.FindByEmailAsync(model.Email);
            if (account == null) throw new ApiException($"No Accounts Registered with {model.Email}.");
            var result = await _userManager.ResetPasswordAsync(account, model.Token, model.Password);
            if (result.Succeeded)
            {
                return new Response<string>(model.Email, message: $"Password Resetted.");
            }
            else
            {
                throw new ApiException($"Error occured while reseting the password.");
            }
        }
    }

}
