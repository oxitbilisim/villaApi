using AutoMapper;
using Villa.Domain.Dtos;
using Villa.Domain.Entities;
using Villa.Infrastructure.ViewModel;

namespace Villa.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Bolge
            CreateMap<Bolge, BolgeDtoC>()
                .ForMember(dest => dest.IlId, opt=> opt.MapFrom(src=> src.Il.Id))
                .ReverseMap();
            CreateMap<BolgeDtoC, Bolge>()
                 .ReverseMap();
            CreateMap<Bolge, BolgeDtoQ>()
                .ReverseMap();
            CreateMap<BolgeDtoQ, Bolge>()
                .ReverseMap();
            #endregion

        }
    }
}
