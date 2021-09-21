using Microsoft.AspNetCore.Mvc;
using PS.Template.Application.Services;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        private readonly IDocenteService _service;
        public DocenteController(IDocenteService service)
        {
            _service = service;   
        }

        [HttpPost]
        public Docente Post(DocenteDTO docente)
        {
            return _service.CreateDocente(docente);
        }
    }
}
