using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string TechnologiesUsed { get; set; }

        public string ProjectUrl { get; set; }

        public string GitHubUrl { get; set; }
    }
}
