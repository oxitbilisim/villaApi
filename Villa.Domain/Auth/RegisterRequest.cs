using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Villa.Domain.Auth
{
    public class RegisterRequest
    {
      
        [Required]
        public string RoleName{ get; set; }

        [Required]
        public string PbikId { get; set; }

        [Required]
        public string Ou { get; set; }


        [Required]
        [MinLength(3)]
        public string Ad { get; set; }

        [Required]
        [MinLength(3)]
        public string Soyad { get; set; }

        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public List<Guid> SorumlulukAlani { get; set; }
    }
}
