﻿using System;
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
        int ActualizarDetalleManteminiento (DetalleMantenimiento detallemantenimiento);

        int EliminarDetalleMantenimiento(DetalleMantenimiento detalleMantenimiento);
        //List<DetalleMantenimiento> ObtenerDetalleXEstado(string estado);
    }
}
