using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class BlogIcerik : BaseSimpleModel
    {
        public BlogIcerik()
        {
        }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public string Icerik { get; set; }
        public string IcerikBasligi { get; set; }

        
    }
}