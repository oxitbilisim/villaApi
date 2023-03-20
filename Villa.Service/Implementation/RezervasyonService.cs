
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Persistence;
using Villa.Service.Base;
namespace Villa.Service.Implementation;

public class RezervasyonService : BaseService<Domain.Entities.Rezervasyon>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    public RezervasyonService( appDbContext appDbContext,
        IMapper mapper) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }

    public async Task<ResponseModel> UpdateBildirim(int Id)
    {
        var rezervasyon = _appDbContext.Rezervasyon.Where(x => x.Id == Id).FirstOrDefault();
        rezervasyon.OpenState = true;
        _appDbContext.Rezervasyon.Update(rezervasyon);
        await _appDbContext.SaveChangesAsync();
        return new ResponseModel(new ResponseModel(Success: true));
    }

    public async Task<ResponseModel> DeleteRezervation(int Id)
    {
        var rezervasyon = _appDbContext.Rezervasyon.Where(x => x.Id == Id).FirstOrDefault();
        rezervasyon.IsDeleted = true;

        _appDbContext.Rezervasyon.Update(rezervasyon);

        var muhasebe = _appDbContext.RezervasyonMaliBilgi.Where(x => x.RezervasyonId == Id).FirstOrDefault();
        if(muhasebe != null)
        {
            muhasebe.IsDeleted = true;
            _appDbContext.RezervasyonMaliBilgi.Update(muhasebe);
        }
       
        await _appDbContext.SaveChangesAsync();
        return new ResponseModel(new ResponseModel(Success: true));
    }

    public ResponseModel MuhasebeCalculate()
    {
         var muhasebe = _appDbContext.RezervasyonMaliBilgi.
             Include(y=> y.Rezervasyon).Where(y => y.IsDeleted==false)
             .Select(x=> new 
                 {
                     ToplamTutar =  x.ToplamTutar, 
                     KomisyonOran = x.Komisyon,
                     ToplamTutars = (x.ToplamTutar * x.Komisyon) / 100,
                     Temizlik=x.TahsilExtraTemizlik,
                     RezervasyonId = x.RezervasyonId,
                     VillaId = x.Rezervasyon.VillaId,
                     VillaAd = x.Rezervasyon.Villa.Ad,
                     RezarvasyonMusteriAdSoyad = x.Rezervasyon.MusteriAdSoyad,
                     RezervasyonTarihi = x.Rezervasyon.StartDate 
                  }
             ).OrderByDescending(x=>x.RezervasyonId)
         .ToList();
            
       return new ResponseModel(muhasebe);
    }
    
    public ResponseModel MuhasebeCalculateWeek()
    {
        var query = from t in _appDbContext.RezervasyonMaliBilgi
            group t by new 
            { 
                Week = t.Rezervasyon.StartDate.DayOfWeek,
                Total = (t.ToplamTutar * t.Komisyon) / 100
            } into g
            select new
            {
                Week = g.Key.Week,
                Total = g.Key.Total
            };
            
        return new ResponseModel(query);
    }
    
    public ResponseModel MuhasebeCalculateMonth()
    {
        var query = from t in _appDbContext.RezervasyonMaliBilgi
            group t by new 
            { 
                Month = t.Rezervasyon.StartDate.Month,
                Total = (t.ToplamTutar * t.Komisyon) / 100
            } into g
            select new
            {
                Month = g.Key.Month,
                Total = g.Key.Total
            };
            
        return new ResponseModel(query);
    }
}