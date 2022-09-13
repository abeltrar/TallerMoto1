using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Enums;

namespace TallerMoto.App.Dominio.Entidades
{
    public class Persona
    {
        int IdPersona {get; set; }
        
        string Nombre { get; set; }
        int Cedula { get; set; }
        int Telefono { get; set; }
        string Direccion { get; set; }
        Rol IdRol { get; set; }






    }
}
