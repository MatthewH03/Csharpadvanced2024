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
        }
    }
}
