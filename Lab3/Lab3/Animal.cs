using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public string Colour { get; set; }

        public int Age { get; set; }

        public abstract void Eat();

    }
}
