using Microsoft.AspNetCore.Mvc;
using PS.Template.Application.Services;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriaClinicaController : ControllerBase
    {
        private readonly IHistoriaClinica _service;
        public HistoriaClinicaController(IHistoriaClinica service)
        {
            _service = service;   
        }

        [HttpPost]
        public HistoriaClinica Post(HistoriaClinicaDTO historiaClinica)
        {
            return _service.CreateHistoriaClinica(historiaClinica);
        }
    }
}
