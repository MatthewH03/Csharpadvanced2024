using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Csharpadvanced2024.Data;
using Csharpadvanced2024.Models;
using AutoMapper;
using Csharpadvanced2024.Models.DTOs;

namespace Csharpadvanced2024.Controllers
{
    [ApiVersion("1.0")]
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
        /// Deze endpoint haalt de locaties op volgens DTO.
        /// </summary>
        /// /// <response code="200">Weergeeft bestaande locatie(s).</response>
        /// <response code="404">Geen locatie(s) gevonden.</response>
        [HttpGet]
        [Route("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<LocationDTO>>> GetLocations()
        {
            var locations = await _context.Locations.ToListAsync();
            var locationDTOs = _mapper.Map<List<LocationDTO>>(locations);
            return Ok(locationDTOs);

        }
        // GET: api/Locations api/Locations/GetAll
        /// <summary>
        /// Deze endpoint haalt alle locaties op.
        /// </summary>
        /// /// <response code="200">Weergeeft bestaande locatie(s).</response>
        /// <response code="404">Geen locatie(s) gevonden.</response>
        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocations()
        {
            return await _context.Locations.ToListAsync();

        }
    }
}
