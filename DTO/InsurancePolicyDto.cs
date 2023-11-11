namespace InsuranceApp.DTO
{
    public class InsurancePolicyDto
    {
        public int PolicyNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public string PremiumType { get; set; }
        public double PremiumAmount { get; set; }
        public double SumAssured { get; set; }
        public string Status { get; set; }
        public int PlanId { get; set; }
        //public int ClaimId { get; set; }
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
    }
}
