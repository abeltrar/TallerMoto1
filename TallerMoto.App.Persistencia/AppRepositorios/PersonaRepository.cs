using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class PersonaRepository : IPersona

    {
        private readonly AppContext _context;
        public PersonaRepository(AppContext context)
        {
            _context = context;
        }
        public int Add(Persona persona)
        {
            _context.Personas.Add(persona);
            return _context.SaveChanges();
             
        }
    }
}
