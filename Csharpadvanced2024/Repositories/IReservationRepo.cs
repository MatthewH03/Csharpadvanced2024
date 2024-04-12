using Csharpadvanced2024.Models;

namespace Csharpadvanced2024.Repositories
{
    public interface IReservationRepo
    {
        IEnumerable<Reservation> GetAll();
    }
}
