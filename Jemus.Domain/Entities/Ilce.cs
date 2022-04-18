﻿using Jemus.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jemus.Entities.Models
{
    public class Ilce : BaseSimpleModel
    {
        public Ilce()
        {
        }
      
        public string Ad { get; set; }
        public Guid IlId { get; set; }
        [ForeignKey("IlId")]
        public virtual Il Il { get; set; }
    }
}