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
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        // POST: api/Reservations
        /// <summary>
        /// HTTP Post Reservations.
        /// </summary>
        /// /// <response code="200">Post success.</response>
        /// <response code="400">Post Failed.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ReservationResponseDTO>> Reservations(ReservationRequestDTO reservationRequestDTO, CancellationToken cancellationToken)
        {
            var reservationResponseDTO = await _reservationService.PostReservationAsync(reservationRequestDTO, cancellationToken);
            return Ok(reservationResponseDTO);

        }
    }
}
