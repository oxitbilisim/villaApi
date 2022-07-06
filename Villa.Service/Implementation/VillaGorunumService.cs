using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;
using Villa.Persistence;
using Villa.Service.Base;
using Villa.Service.Contract;

namespace Villa.Service.Implementation;

public class VillaGorunumService : BaseService<VillaGorunum>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    private readonly VillaOzellikService _villaOzellikService;
    private readonly VillaKategoriService _villaKategoriService;
    private readonly VillaGosterimService _villaGosterimService;
    public VillaGorunumService( appDbContext appDbContext,
        IMapper mapper , 
        VillaOzellikService villaOzellikService,
        VillaKategoriService villaKategoriService, 
        VillaGosterimService villaGosterimService
        ) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
        _villaOzellikService = villaOzellikService;
        _villaKategoriService = villaKategoriService;
        _villaGosterimService = villaGosterimService;
    }

    // public override int Add( VillaGorunumDtoC dto)
    //
    // {
    //     _villaOzellikService.AddMany(dto.VillaOzellik);
    //     _villaKategoriService.AddMany(dto.VillaOzellik);
    //     _villaGosterimService.AddMany(dto.VillaGosterim);
    //
    //        
    //     _appDbContext.SaveChanges();
    //     
    //     return 1;
    // }
}
