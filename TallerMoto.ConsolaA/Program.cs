using System;
using TallerMoto.App.Persistencia.AppRepositorios;
using TallerMoto.App.Dominio;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.ConsolaA
{
    class Program
    {
        private static ICategoria categoria = new CategoriaRepository(new App.Persistencia.AppRepositorios.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Registrando datos...");

            var categoriap = new Categoria
            {
                Descripcion = "Prueba"
            };

       
          

           
        }
    }
}
