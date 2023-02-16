
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Villa.Domain.Dtos;
using Villa.Domain.Enum;
using Villa.Persistence;
using Villa.Service.Base;
namespace Villa.Service.Implementation;

public class TakvimService : BaseService<Domain.Entities.Rezervasyon>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    private readonly RezervasyonService _rezervasyonService;
    public TakvimService( appDbContext appDbContext,
        RezervasyonService rezervasyonService,
        IMapper mapper) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
        _rezervasyonService = rezervasyonService;
    }
    
    public HashSet<TakvimDtoQ>  GetVillaByIdCalendarData(int villaId)
    {
        var getRezervasyonList  = _rezervasyonService.GetAllPI<TakvimRezarvasyonDtoQ>(x=> x.VillaId == villaId 
                                                                                  && x.IsDeleted == false &&x.RezervasyonDurum!=RezervasyonDurum.IncelemeBekliyor).OrderBy(x=> x.Baslangic);
        
        var takvimLiaList = new HashSet<TakvimDtoQ>();
        foreach (var item in getRezervasyonList)
        {
            for (var dt = item.Baslangic; dt <= item.Bitis; dt = dt.AddDays(1))
            {
                TakvimYarimGun takvimYarim = TakvimYarimGun.Yok;
                if (dt.Date == item.Baslangic.Date)
                    takvimYarim = TakvimYarimGun.Basta;
                if (dt.Date == item.Bitis.Date)
                    takvimYarim = TakvimYarimGun.Sonda;
                        
                TakvimDtoQ takvim = new() {
                    Tarih = dt.Date,
                    TakvimYarimGun = takvimYarim,
                    RezervasyonDurum = item.RezervasyonDurum
                };
                
                if (!takvimLiaList.Any(y=> y.Tarih == dt.Date && y.TakvimYarimGun == TakvimYarimGun.Yok))
                    takvimLiaList.Add(takvim);
            }
        }
        return takvimLiaList;
    }
}
