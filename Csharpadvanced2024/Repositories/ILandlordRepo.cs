using Csharpadvanced2024.Models;
using Csharpadvanced2024.Models.DTOs;

namespace Csharpadvanced2024.Repositories
{
    public interface ILandlordRepo
    {
        IEnumerable<Landlord> GetAllLandlords();
    }
}

