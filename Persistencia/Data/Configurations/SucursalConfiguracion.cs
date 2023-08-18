using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
    public class SucursalConfiguracion:IEntityTypeConfiguration<Sucursal>
{
    public void Configure(EntityTypeBuilder<Sucursal> builder)
    {
        builder.ToTable("Sucursales");

        builder.Property(p=>p.Nombre)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=>p.Direccion)
        .HasMaxLength(255)
        .IsRequired();

        builder.Property(p=>p.Telefono)
        .HasMaxLength(20)
        .IsRequired();
        
    }

    
}