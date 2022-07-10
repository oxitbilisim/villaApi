namespace Villa.Domain.Entities;

public class RezervasyonOperasyon : BaseSimpleModel
{
    public RezervasyonOperasyon()
    {
        
    }
    public int RezervasyonId  { get; set; }
    public virtual Rezervasyon Rezervasyon { get; set; }
    
    public bool? Temizlik { get; set; }
    public bool? Havuz { get; set; }
    public bool? Kepozito { get; set; }
    public bool? Kapora { get; set; }
    public bool? Karşılama { get; set; }
    public bool? Tahsilat { get; set; }
}