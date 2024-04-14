using Csharpadvanced2024.Models.DTOs;
using Csharpadvanced2024.Models;

namespace Csharpadvanced2024.Services
{
    public interface ISearchService
    {
        public Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDTO searchRequestDTO, CancellationToken cancellationToken);
    }
}
