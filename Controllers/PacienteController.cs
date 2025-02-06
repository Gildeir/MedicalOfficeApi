using MedicalOfficeApi.Model.Entities;
using MedicalOfficeApi.Repository;
using MedicalOfficeApi.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedicalOfficeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController: ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteController(IPacienteRepository pacientePacienteRepository)
        {
            _pacienteRepository = pacientePacienteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Paciente>>> Get()
        {
            var result = await _pacienteRepository.Get();

            return result.ToList();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> GetById(int id)
        {
            var paciente = await _pacienteRepository.GetById(id);
           
            if (paciente == null)
            {
                return NotFound();
            }
            return Ok(paciente);
        }


    }
}
