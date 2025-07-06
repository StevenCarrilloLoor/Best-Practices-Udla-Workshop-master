
// ARCHIVO NUEVO - Factory para el modelo Escape

using Best_Practices.ModelBuilders;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordEscapeCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder
                .SetBrand("Ford")
                .SetModel("Escape")
                .SetColor("Red") // Según requisitos
                .SetDefaultProperties()
                .AddProperty("Type", "Compact SUV")
                .AddProperty("SeatingCapacity", 5)
                .Build();
        }
    }
}