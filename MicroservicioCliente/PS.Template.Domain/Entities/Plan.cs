using System;

namespace PS.Template.Domain.Entities
{
    public class Plan
    {
        public int PlainId { get; set; }
        public string NombrePlan { get; set; }
        public string Descripcion { get; set; }
        public double Descuento { get; set; }
        public double PrecioPlan { get; set; }
    }
}
