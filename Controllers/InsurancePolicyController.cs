using InsuranceApp.DTO;
using InsuranceApp.Exceptions;
using InsuranceApp.Models;
using InsuranceApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsurancePolicyController : ControllerBase
    {
        private IInsurancePolicyService _insurancePolicyService;
        public InsurancePolicyController(IInsurancePolicyService insurancePolicyService)
        {
            _insurancePolicyService = insurancePolicyService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<InsurancePolicyDto> insurancePolicyDtos = new List<InsurancePolicyDto>();
            var insurancePolicies = _insurancePolicyService.GetAll();
            if (insurancePolicies.Count > 0)
            {
                foreach (var insurancePolicy in insurancePolicies)
                    insurancePolicyDtos.Add(ConvertToDto(insurancePolicy));
                return Ok(insurancePolicyDtos);
            }
            throw new EntityNotFoundError("No Such Insurance Policy Found");
            //return NotFound("No users created");
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var insurancePolicy = _insurancePolicyService.Get(id);
            if (insurancePolicy != null)
                return Ok(ConvertToDto(insurancePolicy));
            throw new EntityNotFoundError("No Such Insurance Policy Found");
            //return BadRequest("No such User Found");
        }
        [HttpPost]
        public IActionResult Add(InsurancePolicyDto insurancePolicyDto)
        {
            var insurancePolicy = ConvertToModel(insurancePolicyDto);
            int id = _insurancePolicyService.Add(insurancePolicy);
            if (id != null)
                return Ok(id);
            throw new EntityInsertError("Some issue while adding Insurance Policy");
            //return BadRequest("Some issue while adding record");
        }
        [HttpPut]
        public IActionResult Update(InsurancePolicyDto insurancePolicyDto)
        {
            var existingPolicy = _insurancePolicyService.Check(insurancePolicyDto.PolicyNo);
            if (existingPolicy != null)
            {
                var insurancePolicy = ConvertToModel(insurancePolicyDto);
                var modifiedPolicy = _insurancePolicyService.Update(insurancePolicy);
                return Ok(ConvertToDto(modifiedPolicy));
            }
            throw new EntityNotFoundError("No Such Insurance Policy Exists");
            //return BadRequest("No such record exists");
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            var insurancePolicyToDelete = _insurancePolicyService.Check(id);
            if (insurancePolicyToDelete != null)
            {
                _insurancePolicyService.Delete(insurancePolicyToDelete);
                return Ok(insurancePolicyToDelete.PlanId);
            }
            throw new EntityNotFoundError("No Such Insurance Policy exists");
            //return BadRequest("No such record exists");
        }
        private InsurancePolicyDto ConvertToDto(InsurancePolicy insurancePolicy)
        {
            return new InsurancePolicyDto()
            {
                PolicyNo = insurancePolicy.PolicyNo,
                IssueDate = insurancePolicy.IssueDate,
                MaturityDate = insurancePolicy.MaturityDate,
                PremiumType = insurancePolicy.PremiumType,
                PremiumAmount = insurancePolicy.PremiumAmount,
                SumAssured = insurancePolicy.SumAssured,
                Status = insurancePolicy.Status,
                PlanId = insurancePolicy.PlanId,
                ClaimId = insurancePolicy.ClaimId,
                PaymentId = insurancePolicy.PaymentId,
                //Contacts = user.Contacts
            };
        }
        private InsurancePolicy ConvertToModel(InsurancePolicyDto insurancePolicyDto)
        {
            return new InsurancePolicy()
            {
                PolicyNo = insurancePolicyDto.PolicyNo,
                IssueDate = insurancePolicyDto.IssueDate,
                MaturityDate = insurancePolicyDto.MaturityDate,
                PremiumType = insurancePolicyDto.PremiumType,
                PremiumAmount = insurancePolicyDto.PremiumAmount,
                SumAssured = insurancePolicyDto.SumAssured,
                Status = insurancePolicyDto.Status,
                PlanId = insurancePolicyDto.PlanId,
                ClaimId = insurancePolicyDto.ClaimId,
                PaymentId = insurancePolicyDto.PaymentId,
                IsActive = true,
                //Contacts = userDto.Contacts
            };
        }
    }
}
