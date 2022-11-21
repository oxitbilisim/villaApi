using System;
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

    public class VillaImageService : BaseService<VillaImage>
    {
        private readonly IMapper _mapper;
        private readonly appDbContext _appDbContext;
        public VillaImageService( appDbContext appDbContext,
            IMapper mapper) :  base(appDbContext, mapper)
        {
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

    public ResponseModel villaImageDeleteAll(int villaId)
    {
        try
        {
            var villaImage = _appDbContext.VillaImage.Where(x => x.VillaId == villaId).ToList();
            _appDbContext.VillaImage.RemoveRange(villaImage);
            _appDbContext.SaveChanges();
            var villaImageDetail = _appDbContext.VillaImageDetay.Where(x => x.VillaId == villaId).ToList();
            _appDbContext.VillaImageDetay.RemoveRange(villaImageDetail);
            _appDbContext.SaveChanges();
            return new ResponseModel(Message: "Baþarýyla Silindi", true);
        }
        catch
        {
            return new ResponseModel(Message: "Baþarýyla Silinemedi", false);
        }
    }
}
  