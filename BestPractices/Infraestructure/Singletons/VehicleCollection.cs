
// ARCHIVO MODIFICADO - Implementación thread-safe

using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Singletons
{
    public sealed class VehicleCollection
    {
        // Thread-safe Singleton implementation usando Lazy<T>
        private static readonly Lazy<VehicleCollection> lazy = 
            new Lazy<VehicleCollection>(() => new VehicleCollection());

        public static VehicleCollection Instance => lazy.Value;
        
        public ICollection<Vehicle> Vehicles { get; set; }

        private VehicleCollection()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}