using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class CategoriaRepository : ICategoria
    {
        private readonly AppContext _context;
        public CategoriaRepository(AppContext context)
        {
            _context = context;
        }

        public int add(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            return _context.SaveChanges();
        }

        Categoria ICategoria.Find(int id)
        {
           return  _context.Categorias.Find(id);
        }
    }
}
