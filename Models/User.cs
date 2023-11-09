using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public Role Role { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Agent Agent { get; set; }
        public Admin Admin { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
    }
}
