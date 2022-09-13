using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMoto.App.Dominio.Entidades
{
    public class DetalleXRepuesto
    {
        int IdDetalleXRepuestos { get; set; }
        DetalleMantenimiento IdDetalle { get; set; }
        Repuestos IdRepuesto { get; set; }
        string Placa { get; set; }
        int Cantidad { get; set; }


    }
}
