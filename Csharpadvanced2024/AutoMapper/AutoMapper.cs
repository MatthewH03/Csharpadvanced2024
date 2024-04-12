using AutoMapper;
using Csharpadvanced2024.Models;
using Csharpadvanced2024.Models.DTOs;

namespace Csharpadvanced2024.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Location, LocationDTO>();
        }
    }
}
