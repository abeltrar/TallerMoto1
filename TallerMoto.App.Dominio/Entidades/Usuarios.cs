using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMoto.App.Dominio.Entidades
{
    public class Usuarios:Persona
    {
        int IdUsuario { get; set; }
        Persona IdPersona { get; set; }
        string Usuario { get; set; }
        string Contraseña { get; set; }
    }
}
