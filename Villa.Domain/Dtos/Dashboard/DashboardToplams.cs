using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class DashboardToplams 
    {
        public int? villaToplam { get; set; }
        public int bolgeToplam { get; set; }
        public int? kategoriToplam { get; set; }
        public int? rezervasyonGunlukToplam { get; set; }

    }
}