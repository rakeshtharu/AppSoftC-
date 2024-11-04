using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace EDental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController(IDoctorsRepository doctorsRepository) : ControllerBase
    {
        IDoctorsRepository doctorsRepository = doctorsRepository;
        [HttpGet]
        public IActionResult Get()
        {
           var doctors = doctorsRepository.Get();
           return Ok(doctors);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var doctor = doctorsRepository.Get(id);

            if (doctor is null)
                return NotFound($"Doctor with id {id} not found");

            return Ok(doctor);
        }

        [HttpPost]
        public IActionResult Post(Doctors doctor)
        {
            var result = doctorsRepository.Insert(doctor);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(Doctors doctor)
        {
            var result = doctorsRepository.Update(doctor);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Doctors doctor)
        {
            var result = doctorsRepository.Delete(doctor);
            return Ok(result);
        }
    }
}
