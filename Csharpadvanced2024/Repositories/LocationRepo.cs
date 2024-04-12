using Csharpadvanced2024.Data;
using Csharpadvanced2024.Models;
using Microsoft.EntityFrameworkCore;

namespace Csharpadvanced2024.Repositories
{
    public class LocationRepo : ILocationRepo
    {
        private readonly AppDbContext context;
        public LocationRepo(AppDbContext context)
        {
            context = context;
        }

        public IEnumerable<Location> GetAllLocations()
        {
            return context.Locations.ToList();
        }
    }
}
