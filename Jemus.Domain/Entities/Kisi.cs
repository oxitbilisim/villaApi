
using Jemus.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jemus.Entities.Models
{

    public class Kisi : BaseFullModel
    {
        public Kisi()
        {

        }

   
        public string Ad { get; set; }
        [StringLength(250)]
        public string Soyad { get; set; }
        [StringLength(50)]
        public string SicilNo { get; set; }
        [StringLength(12)]
        public string TCKN { get; set; }
        [StringLength(250)]
        public string Eposta { get; set; }
        [StringLength(50)]
        public string TelefonGSM { get; set; }
        public string Resim { get; set; }
        public DateTime? DogumTarihi { get; set; }
     
        public virtual IdentityUser User { get; set; }


    }
}


