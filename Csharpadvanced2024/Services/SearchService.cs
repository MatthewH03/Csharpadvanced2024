using Csharpadvanced2024.Models.DTOs;
using Csharpadvanced2024.Models;
using Csharpadvanced2024.Repositories;

namespace Csharpadvanced2024.Services
{
    public class SearchService : ISearchService
    {
        private readonly ILocationRepo _locationRepo;
        public SearchService(ILocationRepo locationRepo)
        {
            _locationRepo = locationRepo;
        }
        public async Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDTO searchRequestDTO, CancellationToken cancellationToken)
        {
            return await _locationRepo.SearchLocationsAsync(searchRequestDTO, cancellationToken);
        }
    }
}
