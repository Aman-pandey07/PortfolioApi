using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class Experience
    {
        public int Id { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string Company { get; set; }

        public string Location { get; set; }

        [Required]
        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Description { get; set; }
    }
}
