using System.ComponentModel.DataAnnotations;

namespace Jemus.Domain.Auth
{
    public class RegisterRequest
    {
      
        [Required]
        public string RoleName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Ad { get; set; }

        [Required]
        [MinLength(6)]
        public string Soyad { get; set; }

        [Required]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

       
        

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
