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
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<LocationDTO>>> GetLocations()
        {
            var locations = await _context.Locations.ToListAsync();
            var locationDtos = _mapper.Map<LocationDTO>(locations);
            return Ok(locationDtos);

        }
        // GET: api/Locations api/Locations/GetAll
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocations()
        {
            return await _context.Locations.ToListAsync();

        }
    }
}
