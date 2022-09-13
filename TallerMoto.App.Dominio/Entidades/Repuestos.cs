using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMoto.App.Dominio.Entidades
{
    public class Repuestos:Categoria
    {
       int IdRepuesto { get; set; }
        string Nombre { get; set; }
        int Cantidad { get; set; }
        string Referencia { get; set; }
        Categoria Idcategoria { get; set; }

    }
}
