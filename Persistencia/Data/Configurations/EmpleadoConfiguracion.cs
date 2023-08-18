using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
    public class EmpleadoConfiguracion:IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("Empleados");

        builder.Property(p=>p.Nombre)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=>p.Apellido)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=>p.DNI)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p=>p.Direccion)
        .HasMaxLength(255)
        .IsRequired();

        builder.Property(p=>p.Telefono)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p=>p.Cargo)
        .HasMaxLength(50)
        .IsRequired();
        
    }

    
}