using AutoMapper;
using PortfolioApi.Models;
using PortfolioApi.DTOs;

namespace PortfolioApi.Helpers
{
    public class MappingProfile
    {
        public MappingProfile()
        {
            CreateMap<Profile, ProfileDTO>().ReverseMap();
        }
    }
}
