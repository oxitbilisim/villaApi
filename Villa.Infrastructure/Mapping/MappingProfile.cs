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
            
            #region Kategori
            CreateMap<Kategori, KategoriDtoC>()
                 .ReverseMap();
            CreateMap<KategoriDtoC, Kategori>()
                .ReverseMap();
            CreateMap<Kategori, KategoriDtoQ>()
                .ReverseMap();
            CreateMap<KategoriDtoQ, Kategori>()
                .ReverseMap();
            #endregion
            
            #region Villa
            CreateMap<Domain.Entities.Villa, VillaDtoC>()
                .ReverseMap();
            CreateMap<VillaDtoC, Domain.Entities.Villa>()
                .ReverseMap();
            CreateMap<Domain.Entities.Villa, VillaDtoQ>()
                 .ReverseMap();
            CreateMap<VillaDtoQ, Domain.Entities.Villa>()
                .ReverseMap();
            #endregion
            
            #region VillaIcerik
            CreateMap<Domain.Entities.VillaIcerik, VillaIcerikDtoC>()
                .ReverseMap();
            CreateMap<VillaIcerikDtoC, Domain.Entities.VillaIcerik>()
                .ReverseMap();
            #endregion
            
            #region VillaLokasyon
            CreateMap<Domain.Entities.VillaLokasyon, VillaLokasyonDtoC>()
                .ReverseMap();
            CreateMap<VillaLokasyonDtoC, Domain.Entities.VillaLokasyon>()
                .ReverseMap();
            #endregion
            
                   
            #region İl
            CreateMap<Domain.Entities.Il, IlDtoC>()
                .ReverseMap();
            CreateMap<IlDtoC, Domain.Entities.Il>()
                .ReverseMap();
            CreateMap<Domain.Entities.Il, IlDtoQ>()
                .ReverseMap();
            CreateMap<IlDtoQ, Domain.Entities.Il>()
                .ReverseMap();
            #endregion
            
            #region Mulk
            CreateMap<Domain.Entities.Mulk, MulkDtoC>()
                .ReverseMap();
            CreateMap<MulkDtoC, Domain.Entities.Mulk>()
                .ReverseMap();
            CreateMap<Domain.Entities.Mulk, MulkDtoQ>()
                .ReverseMap();
            CreateMap<MulkDtoQ, Domain.Entities.Mulk>()
                .ReverseMap();
            #endregion

        }
    }
}
