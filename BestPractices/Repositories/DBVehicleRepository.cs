
// ARCHIVO MODIFICADO - Implementación completa para cuando la BD esté lista

using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Repositories
{
    public class DBVehicleRepository : IVehicleRepository
    {
        // TODO: Descomentar cuando ApplicationDbContext esté disponible
        // private readonly ApplicationDbContext _context;
        
        // public DBVehicleRepository(ApplicationDbContext context)
        // {
        //     _context = context;
        // }
        
        public void AddVehicle(Vehicle vehicle)
        {
            // TODO: Implementar cuando la BD esté lista
            // _context.Vehicles.Add(vehicle);
            // _context.SaveChanges();
            
            throw new NotImplementedException("Base de datos no disponible aún");
        }

        public Vehicle Find(string id)
        {
            // TODO: Implementar cuando la BD esté lista
            // return _context.Vehicles
            //     .FirstOrDefault(v => v.ID.ToString() == id);
            
            throw new NotImplementedException("Base de datos no disponible aún");
        }

        public ICollection<Vehicle> GetVehicles()
        {
            // TODO: Implementar cuando la BD esté lista
            // return _context.Vehicles.ToList();
            
            throw new NotImplementedException("Base de datos no disponible aún");
        }
    }
}