using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
public class AlquilerConfiguracion : IEntityTypeConfiguration<Alquiler>
{
    public void Configure(EntityTypeBuilder<Alquiler> builder)
    {
        builder.ToTable("Alquileres");

        builder.Property(p=>p.Fecha_Inicio)
        .IsRequired();

        builder.Property(p=>p.Fecha_Fin)
        .IsRequired();

        builder.Property(p=>p.Costo_Total)
        .HasPrecision(10,2)
        .IsRequired();

        builder.Property(p=>p.Estado)
        .HasMaxLength(50)
        .IsRequired();

        builder.HasOne(p=>p.Cliente)
        .WithMany(p=>p.Alquileres)
        .HasForeignKey(p=>p.Id_Cliente)
        .IsRequired();

        builder.HasOne(p=>p.Automovil)
        .WithMany(p=>p.Alquileres)
        .HasForeignKey(p=>p.Id_Automovil)
        .IsRequired();
    }
}
