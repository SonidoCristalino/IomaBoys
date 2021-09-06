using System;
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Docente
    {
        public Guid DocenteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Curso> Curso { get; set; }
    }
}
