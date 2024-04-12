using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Csharpadvanced2024.Data;
using Csharpadvanced2024.Models;

namespace Csharpadvanced2024.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public LocationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Locations
        [HttpGet]
        [Route("")]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocation()
        {
            return await _context.Locations.ToListAsync();
        }
    }
}
