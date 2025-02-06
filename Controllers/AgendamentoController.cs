using MedicalOfficeApi.Model.Entities;
using MedicalOfficeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalOfficeApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly IEmailService _emailService;

        List<AgendamentoModel> agendamentos = new List<AgendamentoModel>();

        public AgendamentoController(IEmailService emailService)
        {

            _emailService = emailService;

            agendamentos.Add(new AgendamentoModel
            {
                Id = 1,
                NomePaciente = "João",
                Horario = DateTime.Now,

            });

            agendamentos.Add(new AgendamentoModel
            {
                Id = 2,
                NomePaciente = "Felícia",
                Horario = new DateTime(2025, 02, 05),

            });
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(agendamentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           var result = agendamentos.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("Erro ao buscar agendamento");
        }

        [HttpPost]
        public ActionResult<List<AgendamentoModel>> Post(AgendamentoModel postNewAgendamento)
        {

            if(agendamentos is not null)
            {

                var email = _emailService.EnviarEmail("Essa é a mensagem");

            
              }
            agendamentos.Add(postNewAgendamento);

            return agendamentos;
        }
    }

}
