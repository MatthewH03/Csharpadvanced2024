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
        /// <summary>
        /// Deze endpoint haalt de locaties op volgens DTO v2.
        /// </summary>
        /// /// <response code="200">Weergeeft bestaande locatie(s).</response>
        /// <response code="404">Geen locatie(s) gevonden.</response>
        [HttpGet]
        [Route("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<LocationDTOv2>>> GetLocations(CancellationToken cancellationToken)
        {
            var locations = await _context.Locations.ToListAsync(cancellationToken);
            var locationDTOsv2 = _mapper.Map<List<LocationDTOv2>>(locations);
            return Ok(locationDTOsv2);
        }
    }
}
