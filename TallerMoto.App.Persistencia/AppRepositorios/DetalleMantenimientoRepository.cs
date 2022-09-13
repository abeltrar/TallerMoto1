using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class DetalleMantenimientoRepository : IDetalleMantenimiento
    {
        private readonly AppContext _context;
        public DetalleMantenimientoRepository(AppContext context)
        {
            _context = context;
        }
        public int add(DetalleMantenimiento detalleMantenimiento)
        {
            _context.DetalleMantenimientos.Add(detalleMantenimiento);
            return _context.SaveChanges();
        }

       

        DetalleMantenimiento IDetalleMantenimiento.Find(int id)
        {
            return _context.DetalleMantenimientos.Find(id);
        }

        IEnumerable<DetalleMantenimiento> IDetalleMantenimiento.detalleMantenimientos()
        {
            return _context.DetalleMantenimientos;
        }

    }
}
