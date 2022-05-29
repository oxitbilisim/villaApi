﻿using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IBolgeService
    {
        Task<ResponseModel> GetAll();
        Task<Bolge> Get(int id); 
        Task<ResponseModel> Add(BolgeDtoC dto);
        void Update(BolgeDtoC dto);
        void Delete(int id);
     }
}
