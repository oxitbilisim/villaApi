using AutoMapper;
using Jemus.Infrastructure.ViewModel;

namespace Jemus.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            //CreateMap<CustomerModel, Customer>()
            //    .ForMember(dest => dest.Id,
            //            opt => opt.MapFrom(src => src.CustomerId))
            //    .ReverseMap();
        }
    }
}
