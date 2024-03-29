﻿using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class RezervasyonMaliBilgi : BaseSimpleModel
    {
        public RezervasyonMaliBilgi()
        {
  
        }
        public int RezervasyonId  { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }
        public DepozitoDurum DepozitoDurum { get; set; }
        public Double? IndırımsızTutar { get; set; }
        public Double? ToplamTutar { get; set; }
        public Double? KiralamaKaporasi { get; set; }
        public Double? TahsitTutar { get; set; }
        public DateTimeOffset? TahsilatTarihi { get; set; }
        public string TahsilatBanka { get; set; }
        
        public Double? KkOdemeTutar { get; set; }
        public Double? EvSahibiOdenenTutar { get; set; }
        public DateTimeOffset? EvSahibineOdemeTarihi { get; set; }
        public Double? Depozito { get; set; }
        
        public Double? KomisyondanIndirim { get; set; }
        public Double? VillaSahibindenIndirim { get; set; }
        public Double? KomisyonTutari { get; set; }
        public Double? TemizlikGideri { get; set; }
        public Double? HavuzGideri { get; set; }
        public Double? DigerGider { get; set; }
        public Double? TahsilExtraTemizlik { get; set; }
        public Double? Harcama { get; set; }
        public Double? Konaklama { get; set; }
        public Double? Komisyon { get; set; }
        public string FaturaNumarasi { get; set; }
        public DateTimeOffset? FaturaTarihi { get; set; }
        public Double? TransferGeliri { get; set; }
        public Double? RentGeliri { get; set; }
        public Double? YemekSatisi { get; set; }
        public Double? KahvaltiSatisi { get; set; }
        public string Not { get; set; }
    }
}