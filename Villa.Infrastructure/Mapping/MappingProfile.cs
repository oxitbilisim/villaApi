using AutoMapper;
using Villa.Infrastructure.ViewModel;

namespace Villa.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<CustomerModel, Menu>()
            //    .ForMember(dest => dest.Id,
            //            opt => opt.MapFrom(src => src.CustomerId))
            //    .ReverseMap();
        }
    }
}
