using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;
using TallerMoto.App.Dominio.Enums;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IDetalleMantenimiento
    {
        int add(DetalleMantenimiento detalleMantenimiento);
        DetalleMantenimiento Find(int id);
        IEnumerable<DetalleMantenimiento> detalleMantenimientos();
        IEnumerable<DetalleMantenimiento> ObtenerDetalleXEstado(Estado estado);
        int ActualizarDetalle(DetalleMantenimiento detalle);
    }
}
