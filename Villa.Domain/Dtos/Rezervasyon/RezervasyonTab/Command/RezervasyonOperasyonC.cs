using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos;

public class RezervasyonOperasyonC
{
    public int RezervasyonId  { get; set; }
    public bool? Temizlik { get; set; }
    public bool? Havuz { get; set; }
    public bool? Kepozito { get; set; }
    public bool? Kapora { get; set; }
    public bool? Karşılama { get; set; }
    public bool? Tahsilat { get; set; }
}
