using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
    public class ReservaConfiguracion:IEntityTypeConfiguration<Reserva>
{
    public void Configure(EntityTypeBuilder<Reserva> builder)
    {
        builder.ToTable("Reservas");

        builder.Property(p=>p.Fecha_Reserva)
        .IsRequired();

        builder.Property(p=>p.Fecha_Inicio)
        .IsRequired();

        builder.Property(p=>p.Fecha_Fin)
        .IsRequired();

        builder.Property(p=>p.Estado)
        .HasMaxLength(50)
        .IsRequired();

        builder.HasOne(p=>p.Cliente)
        .WithMany(p=>p.Reservas)
        .HasForeignKey(p=>p.Id_Cliente)
        .IsRequired();

        builder.HasOne(p=>p.Automovil)
        .WithMany(p=>p.Reservas)
        .HasForeignKey(p=>p.Id_Automovil)
        .IsRequired();
        
    }

    
}