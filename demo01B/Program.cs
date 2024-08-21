using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para personas 
            persona persona = new persona();
            persona.Nombres = " Sebastian ";
            persona.Apellidos = " Cisneros ";
            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);
            persona persona1 = new persona
            {
                Nombres = " Carlos ",
                Apellidos = " Torrico",
                Edad = 5
            };
            //Para triangulo
            triangulo triangulo = new triangulo();
            triangulo.Base = 10;
            triangulo.Altura = 5;
            triangulo.CalcularAreas();
            //para estudiante
            estudiante estudiante = new estudiante
            {
                Nombres = " Sebas",
                Apellidos = " Cisneros",
                Nota = 20

            };

            //ejercicio01 

            Cordenada c1 = new Cordenada(0, 0);
            Cordenada c2 = new Cordenada(4, 0);
            Cordenada c3 = new Cordenada(4, 3);

            Ejercicio01 ejercicio01= new Ejercicio01(c1, c2, c3);

            Console.WriteLine(ejercicio01.CalcularPerimetro());
            Console.WriteLine(ejercicio01.CalcularArea());


            Console.WriteLine(triangulo.Area);
            Console.WriteLine("hola mundo");
            Console.Read();
       

        }
    }
}
