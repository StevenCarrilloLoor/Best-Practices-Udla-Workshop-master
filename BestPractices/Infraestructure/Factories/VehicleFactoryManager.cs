
// ARCHIVO NUEVO - Gestor centralizado de factories

using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    public class VehicleFactoryManager
    {
        private readonly Dictionary<string, Creator> _factories;
        
        public VehicleFactoryManager()
        {
            _factories = new Dictionary<string, Creator>
            {
                { "Mustang", new FordMustangCreator() },
                { "Explorer", new FordExplorerCreator() },
                { "Escape", new FordEscapeCreator() }
            };
        }
        
        public Vehicle CreateVehicle(string type)
        {
            if (_factories.ContainsKey(type))
            {
                return _factories[type].Create();
            }
            
            throw new ArgumentException($"Vehicle type '{type}' not supported");
        }
        
        // Método para registrar nuevas factories dinámicamente
        public void RegisterFactory(string type, Creator factory)
        {
            _factories[type] = factory;
        }
    }
}