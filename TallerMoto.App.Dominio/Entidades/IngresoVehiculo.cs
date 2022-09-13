using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMoto.App.Dominio.Entidades
{
    public class IngresoVehiculo: Persona
    {          
        int IdIngreso { get; set; }
        Persona IdUsuario { get; set; }
        Persona IdRecepcionista { get; set; }
        Persona IdMecanico { get; set; }
        string TipoVehiculo { get; set; }
        string Descripcion { get; set; }
        string Placa { get; set; }
        DateTime FechaIngreso { get; set; }





    }
}