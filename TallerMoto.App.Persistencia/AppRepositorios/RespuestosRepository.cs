using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class RespuestosRepository:IRepuestos
    {
        private readonly AppContext _context;
        public RespuestosRepository(AppContext context)
        {
            _context = context;
        }
       
        public int Add(Repuestos repuestos)
        {
            _context.repuestos.Add(repuestos);
            return _context.SaveChanges();
        }

      
        Repuestos IRepuestos.Find(int id)
        {
            return _context.repuestos.Find(id);
        }

         IEnumerable<Repuestos> IRepuestos.ObtenerRepuestos()
        {
            return _context.repuestos;
        }

    }
}
