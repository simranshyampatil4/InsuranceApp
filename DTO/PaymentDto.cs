namespace InsuranceApp.DTO
{
    public class PaymentDto
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get; set; }
    }
}
