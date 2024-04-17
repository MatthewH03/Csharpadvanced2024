using Csharpadvanced2024.Models;
using Csharpadvanced2024.Models.DTOs;

namespace Csharpadvanced2024.Repositories
{
    public interface ILocationRepo
    {
        IEnumerable<Location> GetAllLocations();
        Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDTO searchRequestDto, CancellationToken cancellationToken);
        Task<int> GetMaxPriceAsync(CancellationToken cancellationToken);
        Task<Location> GetDetailsLocationsAsync(int id, CancellationToken cancellationToken);
        Task<List<DateTime>> GetUnavailableDatesAsync(int id,  CancellationToken cancellationToken);
    }
}
