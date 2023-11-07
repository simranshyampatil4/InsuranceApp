using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace InsuranceApp.Models
{
    public class InsurancePolicy
    {
        [Key]
        public int PolicyNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public string PremiumType { get; set; }
        public double PremiumAmount { get; set; }
        public double SumAssured { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public InsurancePlan InsurancePlan { get; set; }
        [ForeignKey("InsurancePlan")]
        public int PlanId { get; set; }

        public Claim Claim { get; set; }
        [ForeignKey("Claim")]
        public int ClaimId { get; set; }

        public Payment PaidPremiums { get; set; }
        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
    }
}
