using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PS.Template.Application.Services
{
    public class HistoriaClinicaService : IHistoriaClinicaService
    {
        private readonly IGenericsRepository _repository;
        private readonly IHistoriaClinicaQuery _query;
        public HistoriaClinicaService(IGenericsRepository repository, IHistoriaClinicaQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public HistoriaClinica CreateHistoriaClinica(HistoriaClinicaDTO historiaClinica)
        {

            var entity = new HistoriaClinica
            {
                ClienteId = historiaClinica.ClienteId,
                TurnoId = historiaClinica.TurnoId,
                Diagnostico = historiaClinica.Diagnostico,
                Imagen = historiaClinica.Imagen,
            };

            _repository.Add<HistoriaClinica>(entity);

            return entity;
        }
        public IList<HistoriaClinicaDTO> GetAll()
        {
            return _query.GetAll();
        }
        public HistoriaClinica GetById(int historiaClincaId)
        {
            return _query.GetById(historiaClincaId);
        }
    }

}
