using EstadisticaFutbol.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EstadisticaFutbol.EntityConfigurations
{
    public class CampeonatoConfiguracion : EntityTypeConfiguration<Campeonato>
    {
        public CampeonatoConfiguracion()
        {
            ToTable("CAMPEONATO");

            Property(c => c.Id)
                .HasColumnName("CODIGO");

            Property(c => c.Descripcion)
                .HasColumnName("DESCRIPCION")
                .HasColumnType("NVARCHAR2")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.FechaInicio)
                .HasColumnName("FECHA_INICIO")
                .IsRequired();

            Property(c => c.FechaCulminacion)
                .HasColumnName("FECHA_CULMINACION")
                .IsRequired();
        }
    }
}