using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Reflection;

namespace PS.Template.Application.Services
{
    public class DocenteService : IDocenteService
    {
        private readonly IGenericsRepository _repository;
        public DocenteService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public Docente CreateDocente(DocenteDTO docente)
        {

            var entity = new Docente
            {
                DocenteId = Guid.NewGuid(),
                Apellido = docente.Apellido,
                Nombre = docente.Nombre,
            };

            _repository.Add<Docente>(entity);

            return entity;
        }
    }
}
