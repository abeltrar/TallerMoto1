using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class IngresoVehiculoRepository:IIngresoVehiculo
    {
        private readonly AppContext _context;
        public IngresoVehiculoRepository(AppContext context)
        {
            _context = context;
        }

        public int add(IngresoVehiculo ingresoVehiculo)
        {
            _context.IngresoVehiculos.Add(ingresoVehiculo);
            return _context.SaveChanges();
        }
    }
}
