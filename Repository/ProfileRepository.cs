using Microsoft.EntityFrameworkCore;
using PortfolioApi.Data;
using PortfolioApi.Models;

namespace PortfolioApi.Repository
{
    public class ProfileRepository : IProfileRepository
    {

        private readonly AppDbContext _context;

        public ProfileRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Profile> GetProfileAsync()
        {
            return await _context.Profiles.FirstOrDefaultAsync();
        }

        public async Task<Profile> UpdateProfileAsync(Profile profile)
        {
            _context.Profiles.Update(profile);
            await _context.SaveChangesAsync();
            return profile;
        }
    }
}
