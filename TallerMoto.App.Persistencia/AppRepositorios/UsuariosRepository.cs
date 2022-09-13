﻿using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class UsuariosRepository : IUsuario
    {
        private readonly AppContext _context;
        public UsuariosRepository(AppContext context)
        {
            _context = context;
        }

        public int Add(Usuarios usuarios)
        {
            _context.Usuario.Add(usuarios);
            return _context.SaveChanges();
        }

        Usuarios IUsuario.Find(int id)
        {
            return _context.Usuario.Find(id);
        }


         IEnumerable<Usuarios> IUsuario.ObtenerUsuarios()
        {
            return _context.Usuario;
        }

    }
}
