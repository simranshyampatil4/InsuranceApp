using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace InsuranceApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Nominee { get; set; }
        public string NomineeRelation { get; set; }
        public Agent Agent { get; set; }
        [ForeignKey("Agent")]
        public int AgentId { get; set; }

        public List<InsurancePolicy> InsurancePolicies { get; set; }

        public List<Document> Documents { get; set; }
        public bool IsActive { get; set; }
    }
}
