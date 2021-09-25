using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;

namespace PS.Template.Application.Services
{
    public interface IHistoriaClinicaService
    {
        HistoriaClinica CreateHistoriaClinica(HistoriaClinicaDTO historiaClinica);
        IList<HistoriaClinicaDTO> GetAll();
        HistoriaClinica GetById(int clienteId);
    }
}
