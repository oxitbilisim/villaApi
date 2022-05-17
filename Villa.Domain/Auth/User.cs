using Villa.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Villa.Domain.Auth
{
    public class User : IdentityUser
    {
      
        public string Ad { get; set; }

        public string Soyad { get; set; }
        public string PbikId { get; set; }

        public string Ou { get; set; }

        public byte[]? Image { get; set; }

        public string TelefonGSM { get; set; }

 
        public List<RefreshToken> RefreshTokens { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}