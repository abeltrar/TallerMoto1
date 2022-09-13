﻿using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class DetalleXRepuestoRepository:IDetalleXRepuesto
    {
        private readonly AppContext _context;
        public DetalleXRepuestoRepository(AppContext context)
        {
            _context = context;
        }

        public int add(DetalleXRepuesto detalleXRepuesto)
        {
            _context.detalleXRepuestos.Add(detalleXRepuesto);
            return _context.SaveChanges();
        }

        DetalleXRepuesto IDetalleXRepuesto.Find(int id)
        {
            return _context.detalleXRepuestos.Find(id);
        }
    }
}
