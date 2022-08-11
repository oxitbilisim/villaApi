using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Utilities;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    [ApiController]
    [Route("api/VillaImage")]
    public class VillaImageController : ControllerBase, IDisposable
    {
        private readonly VillaImageService _villaImageService;
        private readonly VillaImageDetayService _villaImageDetayService;

        public VillaImageController(VillaImageService villaImageService,
            VillaImageDetayService villaImageDetayService
        )
        {
            _villaImageService = villaImageService;
            _villaImageDetayService = villaImageDetayService;
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaImageService.Get(id);
            if (result is not null)
            {
            
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetImageVillaById))]
        public ResponseModel GetImageVillaById(int id)
        {
            VillaImageDtoQ villaImage = new();
            villaImage = _villaImageService.GetPI<VillaImageDtoQ>(x=> x.VillaId == id).FirstOrDefault();
            villaImage.ImageList = _villaImageDetayService.GetPI<VillaImageDetayDtoQ>(x => x.VillaId == id).OrderBy(x=> x.Id).ToList();
         
            if (villaImage is not null)
            {
                return new ResponseModel(villaImage);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaImageDtoC dto)
        {
            var result =  _villaImageService.Add(dto);
            
            foreach (var item in dto.ImageList)
            {
                item.VillaId = dto.VillaId;
                _villaImageDetayService.Add(item);
            }
            
            return  new ResponseModel(result);
        }
        
        [HttpPost(nameof(KapakResimUpdate))]
        public ResponseModel KapakResimUpdate(int? villaId, int resimId)
        {
            
            var result = _villaImageDetayService.KapakResimUpdate(villaId,resimId);
        
            return  new ResponseModel(result);
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaImageDtoC dto)
        {
            return  new ResponseModel(_villaImageService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaImageService.Delete(Id));
        }
        
        [HttpDelete(nameof(DeleteImage))]
        public ResponseModel DeleteImage(int Id)
        {
            return  new ResponseModel(_villaImageDetayService.DeleteHard(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}