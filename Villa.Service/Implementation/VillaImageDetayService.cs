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

    public class VillaImageDetayService : BaseService<VillaImageDetay>
    {
        private readonly IMapper _mapper;
        private readonly appDbContext _appDbContext;
        public VillaImageDetayService( appDbContext appDbContext,
            IMapper mapper) :  base(appDbContext, mapper)
        {
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        
        public bool KapakResimUpdate(int? VillaId, int ResimId)
        {
            try
            {
                var imageDetay = _appDbContext.VillaImageDetay.Where(x =>  x.VillaId == VillaId && x.Id != ResimId).ToList();
                foreach (var item in imageDetay)
                {
                    item.KapakResmi = false;
                    _appDbContext.Entry<VillaImageDetay>(item).State = EntityState.Modified;
                }
                _appDbContext.SaveChanges();
            
                var imageDetayFirst = _appDbContext.VillaImageDetay.Where(x => !x.IsDeleted && x.Id == ResimId).FirstOrDefault();
                imageDetayFirst.KapakResmi = true; 
                _appDbContext.Entry<VillaImageDetay>(imageDetayFirst).State = EntityState.Modified;
     
                _appDbContext.SaveChanges();
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
          
        }
        
        public bool ImageSiranoUpdate(List<VillaImageDetaySiraNoUpdate> villaSiraNoUpdate)
        {
            try
            { 
                foreach (var item in villaSiraNoUpdate)
                {
                    var imageDetay = _appDbContext.VillaImageDetay.Where(x =>  x.Id == item.Id).FirstOrDefault();
                    imageDetay.Sirano = item.Sirano;
                    _appDbContext.Entry<VillaImageDetay>(imageDetay).State = EntityState.Modified;
                }
                _appDbContext.SaveChanges();
            
             
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
          
        }
       
    }
  