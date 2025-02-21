using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class Education
    {
        public int Id { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        public string Institution { get; set; }

        public string Location { get; set; }

        [Required]
        public string StartYear { get; set; }

        public string EndYear { get; set; }

        public string Description { get; set; }
    }
}
