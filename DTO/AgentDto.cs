namespace InsuranceApp.DTO
{
    public class AgentDto
    {
        public int AgentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Qualification { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public int UserId { get; set; }
        public double CommissionEarned { get; set; }
        public bool IsActive { get; set; }
    }
}
