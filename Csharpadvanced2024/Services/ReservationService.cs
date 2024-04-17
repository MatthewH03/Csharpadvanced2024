using Csharpadvanced2024.Models.DTOs;
using Csharpadvanced2024.Models;
using Csharpadvanced2024.Repositories;
using Microsoft.IdentityModel.Tokens;
using Csharpadvanced2024.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Csharpadvanced2024.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ILocationRepo _locationRepo;
        private readonly AppDbContext _context;
        public ReservationService(ILocationRepo locationRepo, AppDbContext context)
        {
            _locationRepo = locationRepo;
            _context = context;
        }
        public async Task<ReservationResponseDTO> PostReservationAsync(ReservationRequestDTO reservationRequestDTO, CancellationToken cancellationToken)
        {
            var unavailableDates = await _locationRepo.GetUnavailableDatesAsync(reservationRequestDTO.LocationId, cancellationToken);
            var location = await _locationRepo.GetDetailsLocationsAsync(reservationRequestDTO.LocationId, cancellationToken);
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Email == reservationRequestDTO.Email, cancellationToken);
            
            if (customer == null)
            {
                if (string.IsNullOrWhiteSpace(reservationRequestDTO.Email))
                {
                    string errorMessageEmail = "Geef tenminste een e-mail op.";
                    throw new ArgumentException(errorMessageEmail);
                }
                customer = new Customer
                {
                    Email = reservationRequestDTO.Email,
                    FirstName = reservationRequestDTO.FirstName,
                    LastName = reservationRequestDTO.LastName
                };

               

                _context.Customers.Add(customer);
                await _context.SaveChangesAsync(cancellationToken);
            }

            if (location == null)
            {
                string errorMessageLocation = "Geen locatie opgegeven.";
                throw new ArgumentException(errorMessageLocation);
            }

            var reservation = new Reservation
            {
                StartDate = reservationRequestDTO.StartDate,
                EndDate = reservationRequestDTO.EndDate,
                CustomerId = customer.Id,
                Discount = reservationRequestDTO.Discount ?? 0,
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync(cancellationToken);

            return new ReservationResponseDTO
            {
                LocationName = location.Title,
                CustomerName = $"{customer.FirstName} {customer.LastName}",
                Price = location.PricePerDay,
                Discount = reservation.Discount
            };
        }
    }
}
