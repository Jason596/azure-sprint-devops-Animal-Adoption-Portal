using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Max", Age = 50, Description = "Mulesoft" },
            new Animal { Id = 2, Name = "Cloudy", Age = 50, Description = "Salesforce" },
            new Animal { Id = 3, Name = "Codey", Age = 50, Description = "Coder" },
            new Animal { Id = 4, Name = "Panda", Age = 50, Description = "China" },
        };
    }
}
