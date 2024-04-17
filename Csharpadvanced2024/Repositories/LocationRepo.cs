using Csharpadvanced2024.Data;
using Csharpadvanced2024.Models;
using Csharpadvanced2024.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Csharpadvanced2024.Repositories
{
    public class LocationRepo : ILocationRepo
    {
        private readonly AppDbContext _context;
        public LocationRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Location> GetAllLocations()
        {
            return _context.Locations.ToList();
        }

        public Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDTO searchRequestDTO, CancellationToken cancellationToken)
        {
            return Task.FromResult<IEnumerable<Location>>(_context.Locations.ToList());
        }

        public async Task<int> GetMaxPriceAsync(CancellationToken cancellationToken)
        {
            return await _context.Locations.MaxAsync(l => (int)l.PricePerDay, cancellationToken);
        }
        public async Task<Location> GetDetailsLocationsAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Locations.FirstOrDefaultAsync(l => l.Id == id, cancellationToken);
        }
        public async Task<List<DateTime>> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDates = await _context.Locations
                .Where(l => l.Id == locationId)
                .SelectMany(l => l.Reservations.Select(r => r.StartDate))
                .ToListAsync(cancellationToken);

            return unavailableDates;
        }
    }
}
