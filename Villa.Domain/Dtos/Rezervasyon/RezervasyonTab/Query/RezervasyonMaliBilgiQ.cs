using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos;

public class RezervasyonMaliBilgiQ
{
    public int RezervasyonId  { get; set; }
    public DepozitoDurum DepozitoDurum { get; set; }
    public Double? IndırımsızTutar { get; set; }
    public Double? ToplamTutar { get; set; }
    public Double? KiralamaKaporasi { get; set; }
    public Double? TahsitTutar { get; set; }
    public DateTime? TahsilatTarihi { get; set; }
    public string TahsilatBanka { get; set; }
        
    public Double? KkOdemeTutar { get; set; }
    public Double? EvSahibiOdenenTutar { get; set; }
    public DateTime? EvSahibineOdemeTarihi { get; set; }
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
    public DateTime FaturaTarihi { get; set; }
    public Double? TransferGeliri { get; set; }
    public Double? RentGeliri { get; set; }
    public Double? YemekSatisi { get; set; }
    public Double? KahvaltiSatisi { get; set; }
    public string Not { get; set; }
}
