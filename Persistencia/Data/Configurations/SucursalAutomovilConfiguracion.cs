using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
    public class SucursalAutomovilConfiguracion:IEntityTypeConfiguration<SucursalAutomovil>
{
    public void Configure(EntityTypeBuilder<SucursalAutomovil> builder)
    {
        builder.ToTable("SucursalAutomoviles");
       

        builder.HasOne(p => p.Automovil)
        .WithMany(p => p.SucursalAutomoviles)
        .HasForeignKey(p => p.Id_Automovil);

        builder.HasOne(p => p.Sucursal)
        .WithMany(p => p.SucursalAutomoviles)
        .HasForeignKey(p => p.Id_Sucursal);

        builder.Property(p=>p.Cantidad_Disponible)
        .IsRequired();
        
        builder.HasKey(p=> new { p.Id_Automovil, p.Id_Sucursal});
        
        
    }

    
}