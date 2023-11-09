using InsuranceApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.DTO
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        //public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}
