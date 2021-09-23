﻿using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Reflection;

namespace PS.Template.Application.Services
{
    class HistoriaClinicaService
    {
        private readonly IGenericsRepository _repository;
        public HistoriaClinicaService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public HistoriaClinica CreateHistoriaClinica(HistoriaClinicaDTO historiaClinica)
        {

            var entity = new HistoriaClinica
            {
                HistoriaClinicaId = historiaClinica.HistoriaClinicaId,
                TurnoId = historiaClinica.TurnoId,
                Diagnostico = historiaClinica.Diagnostico,
                Imagen = historiaClinica.Imagen
            };

            _repository.Add<HistoriaClinica>(entity);

            return entity;
        }
    }
}
