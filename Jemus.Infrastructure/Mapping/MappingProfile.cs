using AutoMapper;
using Jemus.Entities.Models;
using Jemus.Infrastructure.ViewModel;

namespace Jemus.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerModel, Menu>()
                .ForMember(dest => dest.Id,
                        opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}
