using InsuranceApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.DTO
{
    public class ClaimDto
    {
        public int ClaimId { get; set; }
        public double ClaimAmount { get; set; }
        public double BankAccountNumber { get; set; }
        public string BankIfscCode { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        
        public int PolicyNo { get; set; }
    }
}
