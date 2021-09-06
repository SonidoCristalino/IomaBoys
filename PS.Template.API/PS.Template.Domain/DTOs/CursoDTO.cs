using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTOs
{
    public class CursoDTO
    {
        public Guid CursoId { get; set; }
        public string NombreCurso { get; set; }
        public Guid DocenteId { get; set; }

    }
}
