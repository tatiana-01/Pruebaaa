using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;
public class ProyectoContext : DbContext
{
    public ProyectoContext(DbContextOptions<ProyectoContext> options) : base(options)
    {
    }

    public DbSet<Empleado> Empleados {get;set;}
    public DbSet<Registro_Devolucion> Registro_Devoluciones {get;set;}
    public DbSet<Registro_Entrega> Registro_Entregas {get;set;}
    public DbSet<Cliente> Clientes {get;set;}
    public DbSet<Alquiler> Alquileres {get;set;}
    public DbSet<Reserva> Reservas {get;set;}
    public DbSet<Automovil> Automoviles {get;set;}
    public DbSet<Sucursal> Sucursales {get;set;}
    public DbSet<SucursalAutomovil> SucursalAutomoviles {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
