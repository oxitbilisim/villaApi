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
            var imageDetay = _appDbContext.VillaImageDetay.Where(x => x.VillaId == villaSiraNoUpdate[0].VillaId).OrderBy(x=>x.Sirano).ToList();
            //VillaImageDetay image=imageDetay.Find(x => x.Id == villaSiraNoUpdate[0].Id);
            //image.Sirano = villaSiraNoUpdate[0].SiraNo;
            //_appDbContext.Entry<VillaImageDetay>(image).State = EntityState.Modified;
   
              var imageNew = imageDetay.Find(x => x.Id == villaSiraNoUpdate[0].Id );

                imageNew.Sirano = villaSiraNoUpdate[0].SiraNo;
                _appDbContext.Entry<VillaImageDetay>(imageNew).State = EntityState.Modified;

                imageDetay.Remove(imageNew);
                int? count = 0;
                foreach (var item in imageDetay)
                {
                    if(count!= villaSiraNoUpdate[0].SiraNo)
                    {
                        item.Sirano = count;
                        _appDbContext.Entry<VillaImageDetay>(item).State = EntityState.Modified;                       
                    }
                    count++;
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
  