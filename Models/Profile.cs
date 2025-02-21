using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class Profile
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Bio { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string GitHubUrl { get; set; }
    }
}
