﻿using InsuranceApp.DTO;
using InsuranceApp.Models;
using InsuranceApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchemeDetailsController : ControllerBase
    {
        private ISchemeDetailsService _schemeDetailsService;
        public SchemeDetailsController(ISchemeDetailsService schemeDetailsService)
        {
            _schemeDetailsService = schemeDetailsService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<SchemeDetailsDto> schemeDetailsDtos = new List<SchemeDetailsDto>();
            var schemeDetails = _schemeDetailsService.GetAll();
            if (schemeDetails.Count > 0)
            {
                foreach (var schemeDetail in schemeDetails)
                    schemeDetailsDtos.Add(ConvertToDto(schemeDetail));
                return Ok(schemeDetailsDtos);
            }
            return NotFound("No users created");
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var schemeDetail = _schemeDetailsService.Get(id);
            if (schemeDetail != null)
                return Ok(ConvertToDto(schemeDetail));
            return BadRequest("No such User Found");
        }
        [HttpPost]
        public IActionResult Add(SchemeDetailsDto schemeDetailsDto)
        {
            var schemeDetail = ConvertToModel(schemeDetailsDto);
            int id = _schemeDetailsService.Add(schemeDetail);
            if (id != null)
                return Ok(id);
            return BadRequest("Some issue while adding record");
        }
        [HttpPut]
        public IActionResult Update(SchemeDetailsDto schemeDetailsDto)
        {
            var existingDetail = _schemeDetailsService.Check(schemeDetailsDto.DetailId);
            if (existingDetail != null)
            {
                var schemeDetail = ConvertToModel(schemeDetailsDto);
                var modifiedDetail = _schemeDetailsService.Update(schemeDetail);
                return Ok(ConvertToDto(modifiedDetail));
            }
            return BadRequest("No such record exists");
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            var detailsToDelete = _schemeDetailsService.Check(id);
            if (detailsToDelete != null)
            {
                _schemeDetailsService.Delete(detailsToDelete);
                return Ok(detailsToDelete.DetailId);
            }
            return BadRequest("No such record exists");
        }
        private SchemeDetailsDto ConvertToDto(SchemeDetails schemeDetails)
        {
            return new SchemeDetailsDto()
            {
                DetailId = schemeDetails.DetailId,
                SchemeImage = schemeDetails.SchemeImage,
                Description = schemeDetails.Description,
                MinAmount = schemeDetails.MinAmount,
                MaxAmount = schemeDetails.MaxAmount,
                MinInvestmentTime = schemeDetails.MinInvestmentTime,
                MaxInvestmentTime = schemeDetails.MaxInvestmentTime,
                MinAge = schemeDetails.MinAge,
                MaxAge = schemeDetails.MaxAge,
                ProfitRatio = schemeDetails.ProfitRatio,
                RegistrationCommRatio = schemeDetails.RegistrationCommRatio,
                InstallmentCommRatio = schemeDetails.InstallmentCommRatio,
                //Contacts = user.Contacts
            };
        }
        private SchemeDetails ConvertToModel(SchemeDetailsDto schemeDetailsDto)
        {
            return new SchemeDetails()
            {
                DetailId = schemeDetailsDto.DetailId,
                SchemeImage = schemeDetailsDto.SchemeImage,
                Description = schemeDetailsDto.Description,
                MinAmount = schemeDetailsDto.MinAmount,
                MaxAmount = schemeDetailsDto.MaxAmount,
                MinInvestmentTime = schemeDetailsDto.MinInvestmentTime,
                MaxInvestmentTime = schemeDetailsDto.MaxInvestmentTime,
                MinAge = schemeDetailsDto.MinAge,
                MaxAge = schemeDetailsDto.MaxAge,
                ProfitRatio = schemeDetailsDto.ProfitRatio,
                RegistrationCommRatio = schemeDetailsDto.RegistrationCommRatio,
                InstallmentCommRatio = schemeDetailsDto.InstallmentCommRatio,
                IsActive = true,
                //Contacts = userDto.Contacts
            };
        }
    }
}