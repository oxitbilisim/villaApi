﻿using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IVillaImageService
    {
        Task<Domain.Entities.VillaImage> Get(int id); 
        Task<ResponseModel> Add(VillaImageDtoC dto);
        Task<ResponseModel> Update(VillaImageDtoC dto);
        Task<ResponseModel> Delete(int id);
    }
}
