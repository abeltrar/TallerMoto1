using System;
using TallerMoto.App.Persistencia.AppRepositorios;
using TallerMoto.App.Dominio;
using TallerMoto.App.Dominio.Entidades;
using TallerMoto.App.Dominio.Enums;

namespace TallerMoto.ConsolaA
{
    class Program
    {
        private static ICategoria categoria = new CategoriaRepository(new App.Persistencia.AppRepositorios.AppContext());
        private static IDetalleMantenimiento _DetalleMantenimiento = new DetalleMantenimientoRepository(new App.Persistencia.AppRepositorios.AppContext());
        private static DetalleMantenimiento detalleMantenimiento = new DetalleMantenimiento();
        static void Main(string[] args)
        {
         

        }


        public static void ObtenerCategorias()
        {
            var ListadoPersonas = categoria.ObtenerCategorias();

        }

        public static void ObtenerPersonasXGenero()
        {
            var listadoPersonas = _DetalleMantenimiento.ObtenerDetalleXEstado(Estado.En_proceso);

            foreach (var detalle in listadoPersonas)
            {
                Console.WriteLine("IdIngreso" + detalleMantenimiento.IdDetalle + "Fecha Inicio" + detalleMantenimiento.FechaFin);
            }
        }



    }
}
