namespace InsuranceApp.DTO
{
    public class AdminDto
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public bool IsActive { get; set; }
        public int UserId { get; set; } // User reference ID
    }
}
