using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get; set; }
        public bool IsActive { get; set; }
        public InsurancePolicy InsurancePolicy { get; set; }
    }
}
