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
    public class LocationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly ISearchService _searchService;
        private readonly ILocationRepo _locationRepo;

        public LocationsController(AppDbContext context, IMapper mapper, ISearchService searchService, ILocationRepo locationRepo)
        {
            _context = context;
            _mapper = mapper;
            _searchService = searchService;
            _locationRepo = locationRepo;
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
        public async Task<ActionResult<IEnumerable<LocationDTO>>> GetLocations(CancellationToken cancellationToken)
        {
            var locations = await _context.Locations.ToListAsync(cancellationToken);
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
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocations(CancellationToken cancellationToken)
        {
            return await _context.Locations.ToListAsync(cancellationToken);

        }

        // POST: api/Locations/Search
        /// <summary>
        /// HTTP Post Search.
        /// </summary>
        /// /// <response code="200">Success.</response>
        /// <response code="404">Failed.</response>
        [HttpPost]
        [Route("Search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<LocationDTO>>> Search(SearchRequestDTO searchRequestDTO, CancellationToken cancellationToken)
        {
            var locations = await _searchService.SearchLocationsAsync(searchRequestDTO, cancellationToken);
            var locationDTOs = _mapper.Map<List<SearchRequestDTO>>(locations);
            return Ok(locationDTOs);

        }

        // GET: api/Locations/GetMaxPrice
        /// <summary>
        /// Deze endpoint haalt de maximale prijs op.
        /// </summary>
        /// /// <response code="200">Weergeeft de maximale prijs.</response>
        [HttpGet]
        [Route("GetMaxPrice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken)
        {
            int maxPrice = await _locationRepo.GetMaxPriceAsync(cancellationToken);
            var maxPriceDTO = new MaxPriceDTO { Price = maxPrice};
            return Ok(maxPriceDTO);
        }

        // GET: api/Locations/GetDetails/{id}
        /// <summary>
        /// Deze endpoint haalt de details op van een specifieke locatie op id.
        /// </summary>
        /// /// <response code="200">Weergeeft bestaande locatie op id.</response>
        /// <response code="404">Geen locatie gevonden op het gegeven id.</response>
        [HttpGet]
        [Route("GetDetails/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetailLocationDTO>> GetDetailsLocations(int id, CancellationToken cancellationToken)
        {
            var location = await _locationRepo.GetDetailsLocationsAsync(id, cancellationToken);
            if (location == null)
            {
                return NotFound();
            }
            var locationDTO = _mapper.Map<DetailLocationDTO>(location);
            return Ok(locationDTO);
        }

        // GET: api/Locations/UnAvailableDates/{locationId}
        /// <summary>
        /// Deze endpoint haalt de unavailable dates op op locationId.
        /// </summary>
        /// /// <response code="200">Weergeeft bestaande locatie op id.</response>
        /// <response code="404">Geen locatie gevonden op het gegeven id.</response>
        [HttpGet]
        [Route("UnAvailableDates/{locationId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UnavailableDateDTO>> GetUnavailableDates(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDates = await _locationRepo.GetUnavailableDatesAsync(locationId, cancellationToken);
            var unavailableDatesDTO = new UnavailableDateDTO
              {
                  UnavailableDates = unavailableDates
              };
            return Ok(unavailableDates);
        }
    }
}
