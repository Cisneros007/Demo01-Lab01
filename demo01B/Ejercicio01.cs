using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01B
{
    internal class Ejercicio01 
    {
        public Ejercicio01(Cordenada c1, Cordenada c2, Cordenada c3)
        {
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        public Cordenada c1 { get; set; }
        public Cordenada c2 { get; set; }
        public Cordenada c3 { get; set; }




        public static double CalcularDistancia(Cordenada c1, Cordenada c2)
        {
            return Math.Sqrt(Math.Pow(c2.X - c1.X, 2) + Math.Pow(c2.Y - c1.Y, 2));
        }


        public double CalcularPerimetro()
        {
            double a = CalcularDistancia(c1, c2);
            double b = CalcularDistancia(c2, c3);
            double c = CalcularDistancia(c3, c1);
            
            double P = a + b + c;

            return P;
        }
        public double CalcularArea()
        {
            double a = CalcularDistancia(c1, c2);
            double b = CalcularDistancia(c2, c3);
            double c = CalcularDistancia(c3, c1);

            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

   
}
