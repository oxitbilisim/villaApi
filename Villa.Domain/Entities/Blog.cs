using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class Blog : BaseSimpleModel
    {
        public Blog()
        {
        }
 
        // public string FullName
        // {
        //     get { return string.Format("{0} {1}", FirstName, LastName); }
        // }
        
        public string Baslik { get; set; }
        public string? AltBaslik { get; set; }

        public string GirisYazisi { get; set; }
        public string Url { get; set; }
        public string? Etiket  { get; set ; }
        public byte[]? Image { get; set; } 
        public virtual HashSet<BlogIcerik> BlogIcerik { get; set; } 
        public virtual HashSet<BlogSeo> BlogSeo { get; set; } 

        
    }
}