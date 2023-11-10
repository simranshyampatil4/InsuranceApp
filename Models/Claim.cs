using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }
        public double ClaimAmount { get; set; }
        public double BankAccountNumber { get; set; }
        public string BankIfscCode { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public InsurancePolicy InsurancePolicy { get; set; }
        [ForeignKey("InsurancePolicy")]
        public int PolicyNo { get; set; }
        public bool IsActive { get; set; }
    }
}
