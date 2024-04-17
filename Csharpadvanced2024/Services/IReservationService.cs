using Csharpadvanced2024.Models;
using Csharpadvanced2024.Models.DTOs;

namespace Csharpadvanced2024.Services
{
    public interface IReservationService
    {
        public Task<ReservationResponseDTO> PostReservationAsync(ReservationRequestDTO reservationRequestDTO, CancellationToken cancellationToken);
    }
}
