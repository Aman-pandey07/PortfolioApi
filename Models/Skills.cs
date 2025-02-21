using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class Skills
    {
        public int Id { get; set; }

        [Required]
        public string SkillName { get; set; }

        public string Proficiency { get; set; } // e.g., Beginner, Intermediate, Expert

        public string Category { get; set; } // e.g., Programming, Cloud, Tools
    }
}
