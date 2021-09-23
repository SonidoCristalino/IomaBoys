using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Reflection;

namespace PS.Template.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IGenericsRepository _repository;
        public ClienteService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public Cliente CreateCliente(ClienteDTO cliente)
        {

            var entity = new Cliente
            {
                TipoId = cliente.TipoId,
                PlanId = cliente.PlanId,
                PartidoId = cliente.PartidoId,
                HistoriaClinicaId = cliente.HistoriaClinicaId,
                Apellido = cliente.Apellido,
                Nombre = cliente.Nombre,
                DNI = cliente.DNI,
                NumeroCelular = cliente.NumeroCelular,
                Mail = cliente.Mail,
                Contraseña = cliente.Contraseña
            };

            _repository.Add<Cliente>(entity);

            return entity;
        }
    }
}
