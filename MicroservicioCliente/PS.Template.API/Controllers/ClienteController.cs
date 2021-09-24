using Microsoft.AspNetCore.Mvc;
using PS.Template.Application.Services;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;

namespace PS.Template.API.Controllers
{
    [Route("api/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;
        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpPost]
        public Cliente Post(ClienteDTO cliente)
        {
            return _service.CreateCliente(cliente);
        }

        [HttpGet]
        public IList<ClienteDTO> GetClientes()
        {
            return _service.GetAll();
        }

    }
}
