﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/VillaGorunum")]
    public class VillaGorunumController : ControllerBase, IDisposable
    {
        private readonly VillaGorunumService _villaGorunumService;
        private readonly VillaOzellikService _villaOzellikService;
        private readonly VillaKategoriService _villaKategoriService;
        private readonly VillaGosterimService _villaGosterimService;
        
        public VillaGorunumController(
            VillaGorunumService villaGorunumService,
            VillaOzellikService villaOzellikService,
            VillaKategoriService villaKategoriService,
            VillaGosterimService villaGosterimService
            )
        {
            _villaGorunumService = villaGorunumService;
            _villaOzellikService = villaOzellikService;
            _villaKategoriService = villaKategoriService;
            _villaGosterimService = villaGosterimService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaGorunumService.GetPI<VillaGorunumDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetGorunumVillaById))]
        public ResponseModel GetGorunumVillaById(int id)
        {
            VillaGorunumDtoQ result = new();
            result = _villaGorunumService.GetPI<VillaGorunumDtoQ>(x => x.VillaId == id).FirstOrDefault();
            result.VillaOzellik = _villaOzellikService.GetPI<VillaOzellikDtoQ>(x => x.VillaId == id).ToList();
            result.VillaKategori = _villaKategoriService.GetPI<VillaKategoriDtoQ>(x => x.VillaId == id).ToList();
            result.VillaGosterim = _villaGosterimService.GetPI<VillaGosterimDtoQ>(x => x.VillaId == id).ToList();
   
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaGorunumDtoC dto)
        {
            var result =  _villaGorunumService.Add(dto);
            
            foreach (var item in dto.VillaOzellik)
            {
                item.VillaId = dto.VillaId;
                _villaOzellikService.Add(item);
            }
            
            foreach (var item1 in dto.VillaKategori)
            {
                item1.VillaId = dto.VillaId;
                _villaKategoriService.Add(item1);
            }
            
            foreach (var item2 in dto.VillaGosterim)
            {
                item2.VillaId = dto.VillaId;
                _villaGosterimService.Add(item2);
            }
            
            return  new ResponseModel(result);
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaGorunumDtoC dto)
        {
            var result =  _villaGorunumService.Add(dto);


            var ozellik = _villaOzellikService.GetAll(x => x.VillaId == dto.VillaId).ToList();
            foreach (var itemozellik in ozellik)
            {
                _villaOzellikService.DeleteHard((int)itemozellik.Id);
            }
            var kategori =  _villaKategoriService.GetAll(x => x.VillaId == dto.VillaId).ToList();
            foreach (var itemkategori in kategori)
            {
                _villaKategoriService.DeleteHard((int)itemkategori.Id);
            }
            
            var gosterim = _villaGosterimService.GetAll(x => x.VillaId == dto.VillaId).ToList();
            foreach (var itemgosterim in gosterim)
            {
                _villaGosterimService.DeleteHard((int)itemgosterim.Id);
            }
            
            foreach (var item in dto.VillaOzellik)
            {
                item.VillaId = dto.VillaId;
                _villaOzellikService.Add(item);
            }
            
            foreach (var item1 in dto.VillaKategori)
            {
                item1.VillaId = dto.VillaId;
                _villaKategoriService.Add(item1);
            }
            
            foreach (var item2 in dto.VillaGosterim)
            {
                item2.VillaId = dto.VillaId;
                _villaGosterimService.Add(item2);
            }
            
            
            
            return  new ResponseModel(result); 
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaGorunumService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}