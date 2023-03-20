
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
                                                                                  && x.IsDeleted == false &&x.RezervasyonDurum!=RezervasyonDurum.IncelemeBekliyor).OrderBy(x=> x.StartDate);
        
        var takvimLiaList = new HashSet<TakvimDtoQ>();
        foreach (var item in getRezervasyonList)
        {
            for (var dt = item.StartDate; dt <= item.EndDate; dt = dt.AddDays(1))
            {
                TakvimYarimGun takvimYarim = TakvimYarimGun.Yok;
                if (dt == item.StartDate)
                    takvimYarim = TakvimYarimGun.Basta;
                if (dt == item.EndDate)
                    takvimYarim = TakvimYarimGun.Sonda;
                        
                TakvimDtoQ takvim = new() {
                    Tarih = dt,
                    TakvimYarimGun = takvimYarim,
                    RezervasyonDurum = item.RezervasyonDurum
                };
                
                if (!takvimLiaList.Any(y=> y.Tarih == dt && y.TakvimYarimGun == TakvimYarimGun.Yok))
                    takvimLiaList.Add(takvim);
            }
        }
        return takvimLiaList;
    }
}
