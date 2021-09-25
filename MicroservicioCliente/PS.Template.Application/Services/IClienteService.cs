using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;

namespace PS.Template.Application.Services
{
    public interface IClienteService
    {
        Cliente CreateCliente(ClienteDTO cliente);
        IList<ClienteDTO> GetAll();
        Cliente GetById(int clienteId);
    }
}
