using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            IPersona persona = new Nombre("Juan", 30);
            persona.Saludar();
            persona.CumplirAños();
            Console.WriteLine("La edad de la persona es: " + persona.Edad);
        }
    }
}








