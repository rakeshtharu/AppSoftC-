using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Implementations;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosesController(IDiagnosesRepository diagnosesRepository) : ControllerBase
    {
        IDiagnosesRepository diagnosesRepository = diagnosesRepository;
        [HttpGet]
        public IActionResult Get()
        {
            var diagnoses = diagnosesRepository.Get();
            return Ok(diagnoses);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var diagnosis = diagnosesRepository.Get(id);

            if (diagnosis is null)
                return NotFound($"Diagnoses with id {id} not found");

            return Ok(diagnosis);
        }

        [HttpPost]
        public IActionResult Post(Diagnosis diagnosis)
        {
            var result = diagnosesRepository.Insert(diagnosis);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(Diagnosis diagnosis)
        {
            var result = diagnosesRepository.Update(diagnosis);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Diagnosis diagnosis)
        {
            var result = diagnosesRepository.Delete(diagnosis);
            return Ok(result);
        }
    }
}
