using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortfolioApi.DTOs;
using PortfolioApi.Repository;

namespace PortfolioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _repository;
        private readonly IMapper _mapper;

        public ProfileController(IProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ProfileDTO>> GetProfile()
        {
            var profile = await _repository.GetProfileAsync();
            if (profile == null) return NotFound();
            return Ok(_mapper.Map<ProfileDTO>(profile));
        }

        [HttpPut]
        public async Task<ActionResult<ProfileDTO>> UpdateProfile(ProfileDTO profileDTO)
        {
            var profile = _mapper.Map<PortfolioApi.Models.Profile>(profileDTO); // Change the type to PortfolioApi.Models.Profile
            var updatedProfile = await _repository.UpdateProfileAsync(profile);
            return Ok(_mapper.Map<ProfileDTO>(updatedProfile));
        }
    }
}
