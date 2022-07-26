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


    public class BlogIcerikService : BaseService<BlogIcerik>
    {
        private readonly IMapper _mapper;
        private readonly appDbContext _appDbContext;
        public BlogIcerikService( appDbContext appDbContext,
            IMapper mapper) :  base(appDbContext, mapper)
        {
            _mapper = mapper;
            _appDbContext = appDbContext;
        }
  
    }