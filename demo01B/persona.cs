using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01B
{
    internal class persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public string NombresCompletos { get; set; }
        public int Edad { get; set; }

        public string ConocerEdad()
        {
            string mensaje = " es menor de edad";
            if (Edad > 18)
                mensaje = "Es mayor de edad";
            return mensaje;


        }
        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;

        }

    }
}
