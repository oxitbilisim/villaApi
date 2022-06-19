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
            CreateMap<Domain.Entities.VillaIcerik, VillaIcerikDtoQ>()
                .ReverseMap();
            CreateMap<VillaIcerikDtoQ, Domain.Entities.VillaIcerik>()
                .ReverseMap();
            #endregion
            
            #region VillaLokasyon
            CreateMap<Domain.Entities.VillaLokasyon, VillaLokasyonDtoC>()
                .ReverseMap();
            CreateMap<VillaLokasyonDtoC, Domain.Entities.VillaLokasyon>()
                .ReverseMap();
            CreateMap<Domain.Entities.VillaLokasyon, VillaLokasyonDtoQ>()
                .ReverseMap();
            CreateMap<VillaLokasyonDtoQ, Domain.Entities.VillaLokasyon>()
                .ReverseMap();
            
            #endregion
            
            #region VillaGosterim
            CreateMap<Domain.Entities.VillaGosterim, VillaGosterimDtoC>()
                .ReverseMap();
            CreateMap<VillaGosterimDtoC, Domain.Entities.VillaGosterim>()
                .ReverseMap();
            CreateMap<Domain.Entities.VillaGosterim, VillaGosterimDtoQ>()
                .ReverseMap();
            CreateMap<VillaGosterimDtoQ, Domain.Entities.VillaGosterim>()
                .ReverseMap();
            #endregion
            
            #region VillaOzellik
            CreateMap<Domain.Entities.VillaOzellik, VillaOzellikDtoC>()
                .ReverseMap();
            CreateMap<VillaOzellikDtoC, Domain.Entities.VillaOzellik>()
                .ReverseMap();
            CreateMap<Domain.Entities.VillaOzellik, VillaOzellikDtoQ>()
                .ReverseMap();
            CreateMap<VillaOzellikDtoQ, Domain.Entities.VillaOzellik>()
                .ReverseMap();
            #endregion    
            
            
            #region VillaGorunum
            CreateMap<Domain.Entities.VillaGorunum, VillaGorunumDtoC>()
                .ReverseMap();
            CreateMap<VillaGorunumDtoC, Domain.Entities.VillaGorunum>()
                .ReverseMap();
            CreateMap<Domain.Entities.VillaGorunum, VillaGorunumDtoQ>()
                .ReverseMap();
            CreateMap<VillaGorunumDtoQ, Domain.Entities.VillaGorunum>()
                .ReverseMap();
            #endregion
            
            #region VillaImage
            CreateMap<Domain.Entities.VillaImage, VillaImageDtoC>()
                .ReverseMap();
            CreateMap<VillaImageDtoC, Domain.Entities.VillaImage>()
                .ReverseMap();
            CreateMap<Domain.Entities.VillaImage, VillaImageDtoQ>()
                .ReverseMap();
            CreateMap<VillaImageDtoQ, Domain.Entities.VillaImage>()
                .ReverseMap();
            #endregion
            
            #region VillaPeriyodikFiyat
            CreateMap<Domain.Entities.PeriyodikFiyat, VillaPeriyodikFiyatDtoC>()
                .ReverseMap();
            CreateMap<VillaPeriyodikFiyatDtoC, Domain.Entities.PeriyodikFiyat>()
                .ReverseMap();
            CreateMap<Domain.Entities.PeriyodikFiyat, VillaPeriyodikFiyatDtoQ>()
                .ReverseMap();
            CreateMap<VillaPeriyodikFiyatDtoQ, Domain.Entities.PeriyodikFiyat>()
                .ReverseMap();
            #endregion
            
            #region VillaPeriyodikFiyatAyarlari
            CreateMap<Domain.Entities.PeriyodikFiyatAyarlari, VillaPeriyodikFiyatAyarlariDtoC>()
                .ReverseMap();
            CreateMap<VillaPeriyodikFiyatAyarlariDtoC, Domain.Entities.PeriyodikFiyatAyarlari>()
                .ReverseMap();
            CreateMap<Domain.Entities.PeriyodikFiyatAyarlari, VillaPeriyodikFiyatAyarlariDtoQ>()
                .ReverseMap();
            CreateMap<VillaPeriyodikFiyatAyarlariDtoQ, Domain.Entities.PeriyodikFiyatAyarlari>()
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
                          
            #region İlce
            CreateMap<Domain.Entities.Ilce, IlceDtoC>()
                .ReverseMap();
            CreateMap<IlceDtoC, Domain.Entities.Ilce>()
                .ReverseMap();
            CreateMap<Domain.Entities.Ilce, IlceDtoQ>()
                .ReverseMap();
            CreateMap<IlceDtoQ, Domain.Entities.Ilce>()
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
