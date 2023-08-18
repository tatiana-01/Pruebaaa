using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class GenericRepository<T> : IGenericRepository<T>
{
    private readonly ProyectoContext _context;

    public GenericRepository(ProyectoContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
    }

    public virtual ICollection<T> GetAllAsync()
    {
        _context.
    }

    public void GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}



