﻿using DentalBooking.Core.Base;
using DentalBooking.ModelViews.ClinicModelViews;
using DentalBooking_Contract_Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterClinic(ClinicModelView model)
        {
            var createdClinic = await _clinicService.CreateClinicAsync(model);
            return CreatedAtAction(nameof(GetClinic), new { id = createdClinic.Id }, createdClinic);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClinic(int id)
        {
            var clinic = await _clinicService.GetClinicByIdAsync(id);
            if (clinic == null)
            {
                return NotFound();
            }
            return Ok(clinic);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClinic(int id, ClinicModelView model)
        {
            await _clinicService.UpdateClinicAsync(id, model);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClinic(int id)
        {
            await _clinicService.DeleteClinicAsync(id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClinics(int index = 1, int pageSize = 10)
        {
            var clinics = await _clinicService.GetClinicsAsync(index, pageSize);
            return Ok(clinics); // Trả về danh sách phòng khám mà không bọc vào BaseResponse
        }

    }
}
