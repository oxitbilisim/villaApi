using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class Parameters : BaseSimpleModel
    {
        public Parameters()
        {
        }

        public string Code { get; set; }
        public string? Value { get; set; }
    }
}