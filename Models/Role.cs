using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
    }
}
