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
using Csharpadvanced2024.Models.DTOs.v2;
using Csharpadvanced2024.Services;
using Csharpadvanced2024.Repositories;

namespace Csharpadvanced2024.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly ISearchService _searchService;
        private readonly ILandlordRepo _landlordRepo;

        public LandlordsController(AppDbContext context, ILandlordRepo landlordRepo, IMapper mapper)
        {
            _context = context;
            _landlordRepo = landlordRepo;
            _mapper = mapper;
        }
        // GET: api/Landlords
        /// <summary>
        /// Deze endpoint haalt de landlords op.
        /// </summary>
        /// /// <response code="200">Weergeeft bestaande landlord(s).</response>
        /// <response code="404">Geen landlord(s) gevonden.</response>
        [HttpGet]
        [Route("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<LandlordDTO>>> GetLandlords(CancellationToken cancellationToken)
        {
            var landlords = await _context.Landlords.ToListAsync(cancellationToken);
            var landlordDTOs = _mapper.Map<List<LandlordDTO>>(landlords);
            return Ok(landlordDTOs);

        }
    }
}