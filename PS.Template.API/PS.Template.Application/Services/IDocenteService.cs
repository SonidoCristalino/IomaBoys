using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;

namespace PS.Template.Application.Services
{
    public interface IDocenteService
    {
        Docente CreateDocente(DocenteDTO docente);
    }
}
