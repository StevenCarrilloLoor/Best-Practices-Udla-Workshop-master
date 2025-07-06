
// ARCHIVO MODIFICADO - Agregar propiedades por defecto

using Best_Practices.ModelBuilders;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordMustangCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder
                .SetBrand("Ford")
                .SetModel("Mustang")
                .SetColor("Red")
                .SetDefaultProperties() // NUEVO: Establecer propiedades por defecto
                .AddProperty("Type", "Sports Car") // NUEVO: Propiedades específicas
                .AddProperty("Horsepower", 450)
                .Build();
        }
    }
}