using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
    public class ClienteConfiguracion:IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");

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

        builder.Property(p=>p.Email)
        .HasMaxLength(100)
        .IsRequired();
        
    }

    
}