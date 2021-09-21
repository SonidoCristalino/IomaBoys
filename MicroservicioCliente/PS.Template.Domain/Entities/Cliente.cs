using System;
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public int PlanId { get; set; }
        public int PartidoId { get; set; }
    }
}
