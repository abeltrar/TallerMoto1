using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IDetalleXRepuesto
    {
        int add(DetalleXRepuesto detalleXRepuesto);
        DetalleXRepuesto Find(int id);
    }
}
