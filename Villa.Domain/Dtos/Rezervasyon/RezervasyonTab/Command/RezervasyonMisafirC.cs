using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos;

public class RezervasyonMisafirC
{
    public int RezervasyonId  { get; set; }
    public string MisafirAdSoyad { get; set; }
    public string Yas { get; set; }
    public string TcNo { get; set; }
    public Cinsiyet Cinsiyet { get; set; }
}
