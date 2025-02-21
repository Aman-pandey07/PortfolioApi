using PortfolioApi.Models;

namespace PortfolioApi.Repository
{
    public interface IProfileRepository
    {
        Task<Profile> GetProfileAsync();
        Task<Profile> UpdateProfileAsync(Profile profile);
    }
}
