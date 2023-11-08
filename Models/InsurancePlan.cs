using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class InsurancePlan
    {
        [Key]
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public bool IsActive { get; set; }
        public List<InsuranceScheme> insuranceSchemes { get; set; }
        //public InsuranceScheme InsuranceScheme { get; set; }//one to one relationship between insurance plan and scheme
        //[ForeignKey("InsuranceScheme")]
        //public int SchemeId { get; set; }


    }
}
