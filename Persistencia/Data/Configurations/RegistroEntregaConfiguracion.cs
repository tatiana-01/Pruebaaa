using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
    public class RegistroEntregaConfiguracion:IEntityTypeConfiguration<Registro_Entrega>
{
    public void Configure(EntityTypeBuilder<Registro_Entrega> builder)
    {
        builder.ToTable("Registro_Entregas");

        builder.Property(p=>p.Fecha_Entrega)
        .IsRequired();

        builder.Property(p=>p.Combustible_Entregado)
        .HasPrecision(5,2)
        .IsRequired();

        builder.Property(p=>p.Kilometraje_Entregado)
        .IsRequired();

        builder.HasOne(p=>p.Alquiler)
        .WithMany(p=>p.Registro_Entregas)
        .HasForeignKey(p=>p.Id_Alquiler)
        .IsRequired();

        builder.HasOne(p=>p.Empleado)
        .WithMany(p=>p.Registro_Entregas)
        .HasForeignKey(p=>p.Id_Empleado)
        .IsRequired();
        
    }

    
}