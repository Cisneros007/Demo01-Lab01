using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace demo01B
{
    internal class triangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Area { get; set; }

        public int CalcularAreas()
        {
            Area = (Base * Altura) / 2;
            return Area;
        }
    }
}
