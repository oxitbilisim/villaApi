using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class Collections  : BaseSimpleModel
    {
        public Collections()
        {
        }
        public Guid key { get; set; }
    }
}