using AutoMapper;
using Csharpadvanced2024.Data;
using Csharpadvanced2024.Models.DTOs;
using Csharpadvanced2024.Models;
using Microsoft.AspNetCore.Mvc;
using LocationDTOv2 = Csharpadvanced2024.Models.DTOs.v2.LocationDTOv2;
using Microsoft.EntityFrameworkCore;

namespace Csharpadvanced2024.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public LocationsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Locations
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<LocationDTOv2>>> GetLocations()
        {
            var locations = await _context.Locations.ToListAsync();
            var locationDTOsv2 = _mapper.Map<List<LocationDTOv2>>(locations);
            return Ok(locationDTOsv2);
        }
    }
}
