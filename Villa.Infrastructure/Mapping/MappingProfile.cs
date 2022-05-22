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
            CreateMap<Bolge, BolgeDto>()
                .ForMember(dest => dest.IlId, opt=> opt.MapFrom(src=> src.Il.Id))
                .ReverseMap();
            CreateMap<BolgeDto, Bolge>()
                 .ReverseMap();

        }
    }
}
