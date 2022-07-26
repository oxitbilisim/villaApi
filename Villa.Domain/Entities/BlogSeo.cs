using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class BlogSeo  : BaseSimpleModel
    {
        public BlogSeo()
        {
        }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string AnahtarKelime { get; set; }
        public string HtmlMetaEtiket { get; set; }
    }
}