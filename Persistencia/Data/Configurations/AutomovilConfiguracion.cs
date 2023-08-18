using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
    public class AutomovilConfiguracion:IEntityTypeConfiguration<Automovil>
{
    public void Configure(EntityTypeBuilder<Automovil> builder)
    {
        builder.ToTable("Automoviles");

        builder.Property(p=>p.Precio_Diario)
        .HasPrecision(10,2)
        .IsRequired();

        builder.Property(p=>p.Tipo)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p=>p.Modelo)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=>p.Marca)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=>p.Año)
        .IsRequired();

        builder.Property(p=>p.Capacidad)
        .IsRequired();
    }
   
}