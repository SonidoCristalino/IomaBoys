using System;
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int TipoId { get; set; }
        public int PlanId { get; set; }
        public int PartidoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int NumeroCelular { get; set; }
        public string Mail { get; set; }
        public string Contraseña { get; set; }
    }
}
