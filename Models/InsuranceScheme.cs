using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class InsuranceScheme
    {
        [Key]
        public int SchemeId { get; set; }
        public string SchemeName { get; set; }
        public bool IsActive { get; set; }
        public SchemeDetails SchemeDetails { get; set; }
        [ForeignKey("SchemeDetails")]
        public int DetailId { get; set; }
        public List<InsurancePolicy> Policies { get; set; }
    }
}
