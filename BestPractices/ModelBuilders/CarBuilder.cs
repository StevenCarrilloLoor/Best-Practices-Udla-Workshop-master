
// ARCHIVO MODIFICADO - Agregar soporte para propiedades dinámicas y año

using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.ModelBuilders
{
    public class CarBuilder
    {
        private string Brand = "Ford";
        private string Model = "Mustang";
        private string Color = "Red";
        private int Year = DateTime.Now.Year; // NUEVO: Año actual por defecto
        private Dictionary<string, object> _additionalProperties = new Dictionary<string, object>(); // NUEVO

        public CarBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }
        
        // NUEVO: Método para establecer el año
        public CarBuilder SetYear(int year)
        {
            Year = year;
            return this;
        }
        
        // NUEVO: Método para agregar propiedades dinámicas
        public CarBuilder AddProperty(string key, object value)
        {
            _additionalProperties[key] = value;
            return this;
        }
        
        // NUEVO: Método para establecer propiedades por defecto
        public CarBuilder SetDefaultProperties()
        {
            // 20+ propiedades por defecto según requisitos
            _additionalProperties["Engine"] = "V6";
            _additionalProperties["Transmission"] = "Automatic";
            _additionalProperties["FuelType"] = "Gasoline";
            _additionalProperties["Doors"] = 4;
            _additionalProperties["SeatingCapacity"] = 5;
            _additionalProperties["Warranty"] = "3 years";
            _additionalProperties["AirConditioning"] = true;
            _additionalProperties["PowerWindows"] = true;
            _additionalProperties["PowerSteering"] = true;
            _additionalProperties["ABS"] = true;
            _additionalProperties["Airbags"] = 6;
            _additionalProperties["CruiseControl"] = true;
            _additionalProperties["ParkingSensors"] = true;
            _additionalProperties["RearViewCamera"] = true;
            _additionalProperties["GPS"] = true;
            _additionalProperties["Bluetooth"] = true;
            _additionalProperties["USBPorts"] = 4;
            _additionalProperties["TrunkCapacity"] = "500L";
            _additionalProperties["FuelEfficiency"] = "8.5L/100km";
            _additionalProperties["TopSpeed"] = "200km/h";
            
            return this;
        }
        
        public Car Build()
        {
            var car = new Car(Color, Brand, Model);
            car.Year = Year; // NUEVO: Establecer el año
            
            // NUEVO: Copiar propiedades adicionales
            foreach (var prop in _additionalProperties)
            {
                car.AdditionalProperties[prop.Key] = prop.Value;
            }
            
            return car;
        }
    }
}