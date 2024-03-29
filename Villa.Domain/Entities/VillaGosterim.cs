﻿using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class VillaGosterim : BaseSimpleModel
    {
        public VillaGosterim()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        
        public Gosterim Gosterim { get; set; }
    }
}