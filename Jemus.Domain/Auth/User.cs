using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Jemus.Domain.Auth
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string SicilNo { get; set; }
   
        public string TCKN { get; set; }

        public string Eposta { get; set; }

        public string TelefonGSM { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}