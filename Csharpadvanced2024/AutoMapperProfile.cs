using AutoMapper;
using Csharpadvanced2024.Models;
using Csharpadvanced2024.Models.DTOs;
using Csharpadvanced2024.Models.DTOs.v2;

namespace Csharpadvanced2024
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Location, LocationDTO>();
            CreateMap<Location, LocationDTOv2>();
            CreateMap<Location, SearchRequestDTO>()
                .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Rooms, opt => opt.MapFrom(src => src.Rooms))
                .ForMember(dest => dest.MinPrice, opt => opt.Ignore())
                .ForMember(dest => dest.MaxPrice, opt => opt.Ignore());
            CreateMap<Location, DetailLocationDTO>();
        }
    }
}
