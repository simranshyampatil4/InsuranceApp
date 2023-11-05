using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public bool IsActive { get; set; }
        public User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
