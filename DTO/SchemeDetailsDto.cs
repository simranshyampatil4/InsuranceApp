namespace InsuranceApp.DTO
{
    public class SchemeDetailsDto
    {
        public int DetailId { get; set; }
        public string SchemeImage { get; set; }
        public string Description { get; set; }
        public double MinAmount { get; set; }
        public double MaxAmount { get; set; }
        public int MinInvestmentTime { get; set; }
        public int MaxInvestmentTime { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public double ProfitRatio { get; set; }
        public double RegistrationCommRatio { get; set; }
        public double InstallmentCommRatio { get; set; }
    }
}
