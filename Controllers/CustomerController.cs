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
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            var customers = _customerService.GetAll();
            if (customers.Count > 0)
            {
                foreach (var customer in customers)
                    customerDtos.Add(ConvertToDto(customer));
                return Ok(customerDtos);
            }

            throw new EntityNotFoundError("No customers created");
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var customer = _customerService.Get(id);
            if (customer != null)
                return Ok(ConvertToDto(customer));
            throw new EntityNotFoundError("No such customer found");
        }

        [HttpPost]
        public IActionResult Add(CustomerDto customerDto)
        {
            var customerModel = ConvertToModel(customerDto);
            int id = _customerService.Add(customerModel);
            if (id != 0)
                return Ok(id);
            throw new EntityInsertError("Some issue while adding the customer");
        }

        [HttpPut]
        public IActionResult Update(CustomerDto customerDto)
        {
            var existingCustomer = _customerService.Check(customerDto.CustomerId);
            if (existingCustomer != null)
            {
                var customer = ConvertToModel(customerDto);
                var modifiedCustomer = _customerService.Update(customer);
                return Ok(ConvertToDto(modifiedCustomer));
            }
            throw new EntityNotFoundError("No such customer record exists");
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            var customerToDelete = _customerService.Check(id);
            if (customerToDelete != null)
            {
                _customerService.Delete(customerToDelete);
                return Ok(customerToDelete.CustomerId);
            }
            throw new EntityNotFoundError("No such record exists");
        }

        private CustomerDto ConvertToDto(Customer customer)
        {
            return new CustomerDto()
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                MobileNo = customer.MobileNo,
                State = customer.State,
                City = customer.City,
                Nominee = customer.Nominee,
                NomineeRelation = customer.NomineeRelation,
                AgentId = customer.AgentId,
                IsActive = customer.IsActive
            };
        }

        private Customer ConvertToModel(CustomerDto customerDto)
        {
            return new Customer()
            {
                CustomerId = customerDto.CustomerId,
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                Email = customerDto.Email,
                MobileNo = customerDto.MobileNo,
                State = customerDto.State,
                City = customerDto.City,
                Nominee = customerDto.Nominee,
                NomineeRelation = customerDto.NomineeRelation,
                AgentId = customerDto.AgentId,
                IsActive = customerDto.IsActive
            };
        }
    }
}

