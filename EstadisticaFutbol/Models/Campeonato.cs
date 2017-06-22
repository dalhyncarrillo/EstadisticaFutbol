using System;

namespace EstadisticaFutbol.Models
{
    public class Campeonato
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCulminacion { get; set; }
    }
}