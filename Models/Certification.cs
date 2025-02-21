using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class Certification
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string IssuingOrganization { get; set; }

        public string IssueDate { get; set; }

        public string ExpirationDate { get; set; }

        public string CredentialUrl { get; set; }
    }
}
