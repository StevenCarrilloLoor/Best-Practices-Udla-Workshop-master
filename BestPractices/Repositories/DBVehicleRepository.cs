

using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Repositories
{
    public class DBVehicleRepository : IVehicleRepository
    {
        
        public void AddVehicle(Vehicle vehicle)
        {

            throw new NotImplementedException("Base de datos no disponible aún");
        }

        public Vehicle Find(string id)
        {
            
            throw new NotImplementedException("Base de datos no disponible aún");
        }

        public ICollection<Vehicle> GetVehicles()
        {
            
            throw new NotImplementedException("Base de datos no disponible aún");
        }
    }
}