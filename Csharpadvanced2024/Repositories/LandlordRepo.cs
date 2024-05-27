using Csharpadvanced2024.Data;
using Csharpadvanced2024.Models.DTOs;
using Csharpadvanced2024.Models;
using Microsoft.EntityFrameworkCore;

namespace Csharpadvanced2024.Repositories
{
    public class LandlordRepo : ILandlordRepo
    {
        private readonly AppDbContext _context;
        public LandlordRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Landlord> GetAllLandlords()
        {
            return _context.Landlords.ToList();
        }

    }
}
