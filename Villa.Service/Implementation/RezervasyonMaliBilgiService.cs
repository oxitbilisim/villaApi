
using AutoMapper;
using System;
using System.Linq;
using Villa.Domain.Common;
using Villa.Domain.Entities;
using Villa.Persistence;
using Villa.Service.Base;
namespace Villa.Service.Implementation;

public class RezervasyonMaliBilgiService : BaseService<Domain.Entities.RezervasyonMaliBilgi>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    public RezervasyonMaliBilgiService( appDbContext appDbContext,
        IMapper mapper) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }

    public ResponseModel villaMaliBilgi(int rezervasyonId)
    {

        var rezervasyon = _appDbContext.Rezervasyon.Where(x => x.Id == rezervasyonId).FirstOrDefault();
        int totalDays = rezervasyon.EndDate.DayNumber - rezervasyon.StartDate.DayNumber;
        decimal indirimsizTutar = 0;
        decimal toplamTutar = 0;
        decimal kiralamaDepozitosu = 0;
        var baslangicTarihi = rezervasyon.StartDate;
        for (int i = 0; i < totalDays; i++)
        {
            var periyodikFiyat = _appDbContext.PeriyodikFiyat.Where(x => x.VillaId == rezervasyon.VillaId && baslangicTarihi >= x.StartDate && baslangicTarihi <= x.EndDate).FirstOrDefault();
            indirimsizTutar += periyodikFiyat.Fiyat;
            toplamTutar += periyodikFiyat.Fiyat - ((periyodikFiyat.Fiyat * periyodikFiyat.Indirim) / 100);
            kiralamaDepozitosu += (periyodikFiyat.Fiyat*(decimal)(_appDbContext.PeriyodikFiyatAyarlari.Where(X => X.VillaId == rezervasyon.VillaId).FirstOrDefault().Kapora) / 100);
            baslangicTarihi = baslangicTarihi.AddDays(1);
        }
        var villa = _appDbContext.PeriyodikFiyatAyarlari.Where(X => X.VillaId == rezervasyon.VillaId).Select(y => new
        {
            kiralamaDepozitosu =kiralamaDepozitosu,
            indirimsizTutar = indirimsizTutar,
            toplamTutar=toplamTutar,
            gun = totalDays,
            komisyon = y.Komisyon,
            kapora = y.Kapora,
            depozito = y.Depozito,
            temizlikUcreti = y.TemizlikUcreti,
            //bolge = _appDbContext.VillaLokasyon.Where(x => x.VillaId == y.Id).FirstOrDefault().Bolge.Ad
        }
       ).FirstOrDefault();
        return new ResponseModel(villa);
    }
}