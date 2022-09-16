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
        private static IPersona _PersonaRepository = new PersonaRepository(new App.Persistencia.AppRepositorios.AppContext());
        private static DetalleMantenimiento detalleMantenimiento = new DetalleMantenimiento();
        static void Main(string[] args)
        {
            addPersona();

        }

        public static void addPersona()
        {

            Console.WriteLine("Registrando una persona");

            var persona = new Persona
            {
                Nombre = "Juan Carlos",
                Cedula = 1004006369,
                Telefono = 317123456,
                Direccion = "Cll 20 # 30 - 70",
                IdRol = Rol.Admin
            };

            try
            {
                var result = _PersonaRepository.Add(persona);

                if (result > 0)
                    Console.WriteLine("Se inserto correctamente");
                else
                    Console.WriteLine("No se pudo insertar");

            }
            catch (System.Exception e)
            {
                Console.WriteLine("Ocurrio un error: " + e);
                throw;
            }
        }


        public static void ObtenerCategorias()
        {
            var ListadoPersonas = categoria.ObtenerCategorias();

        }

        /*public static void ObtenerPersonasXGenero()
        {
            var listadoPersonas = _DetalleMantenimiento.ObtenerDetalleXEstado(Estado.En_proceso);

            foreach (var detalle in listadoPersonas)
            {
                Console.WriteLine("IdIngreso" + detalleMantenimiento.IdDetalle + "Fecha Inicio" + detalleMantenimiento.FechaFin);
            }
        }*/



    }
}
