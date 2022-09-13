using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Enums;

namespace TallerMoto.App.Dominio.Entidades
{
    public class DetalleMantenimiento:IngresoVehiculo
    {
        int IdDetalle { get; set; }
        IngresoVehiculo IdIngreso { get; set; }
        DateTime FechaInicio { get; set; }
        DateTime FechaFin { get; set; }
        string Observacion { get; set; }
        Estado IdEstado { get; set; }


    }
}
