﻿using Best_Practices.Infraestructure.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Models
{
    public class HomeViewModel
    {
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
