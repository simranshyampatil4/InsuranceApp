using InsuranceApp.Models;

namespace InsuranceApp.DTO
{
    public class InsuranceSchemeDto
    {
        public int SchemeId { get; set; }
        public string SchemeName { get; set; }
        public int DetailId { get; set; }

        //public List<InsurancePolicy> Policies { get; set; }
    }
}
