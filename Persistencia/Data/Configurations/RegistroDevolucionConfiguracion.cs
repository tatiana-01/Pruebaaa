using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
    public class RegistroDevolucionConfiguracion:IEntityTypeConfiguration<Registro_Devolucion>
{
    public void Configure(EntityTypeBuilder<Registro_Devolucion> builder)
    {
        builder.ToTable("Registro_Devoluciones");

        builder.Property(p=>p.Fecha_Devolucion)
        .IsRequired();

        builder.Property(p=>p.Combustible_Devuelto)
        .HasPrecision(5,2)
        .IsRequired();

        builder.Property(p=>p.Kilometraje_Devuelto)
        .IsRequired();

        builder.Property(p=>p.Monto_Adicional)
        .HasPrecision(10,2)
        .IsRequired();

        builder.HasOne(p=>p.Alquiler)
        .WithMany(p=>p.Registro_Devoluciones)
        .HasForeignKey(p=>p.Id_Alquiler)
        .IsRequired();

        builder.HasOne(p=>p.Empleado)
        .WithMany(p=>p.Registro_Devoluciones)
        .HasForeignKey(p=>p.Id_Empleado)
        .IsRequired();
        
    }

    
}