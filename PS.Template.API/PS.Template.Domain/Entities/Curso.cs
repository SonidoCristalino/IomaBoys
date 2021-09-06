using System;

namespace PS.Template.Domain.Entities
{
    public class Curso
    {
        public Guid CursoId { get; set; }
        public string NombreCurso { get; set; }
        public Guid DocenteId { get; set; }
    }
}
