using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class BlogKategori : BaseSimpleModel
    {
        public BlogKategori()
        {
        }
        public string Ad { get; set; }
        public string Url { get; set; }
        public virtual HashSet<BlogIcerik> BlogIcerik { get; set; } 

    }
}