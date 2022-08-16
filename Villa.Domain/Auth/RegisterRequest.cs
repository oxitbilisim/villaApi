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
        [MinLength(3)]
        public string Ad { get; set; }

        [Required]
        [MinLength(3)]
        public string Soyad { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string TelefonGSM { get; set; }
        public byte[] Image { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
