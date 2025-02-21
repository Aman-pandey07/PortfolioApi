using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string LinkedInUrl { get; set; }

        public string GitHubUrl { get; set; }

        public string Message { get; set; }
    }
}
