using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class ExchangeRates : BaseSimpleModel
    {
        public ExchangeRates()
        {
        }

        public string from { get; set; }
        public string to { get; set; }
        public double rate { get; set; }
        public string BulletinNo { get; set; }

    }
}