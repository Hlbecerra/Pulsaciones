using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            int edad;
            int pulsaciones;
            Console.WriteLine("Digite el sexo (F/M): ");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite la edad");
            edad = int.Parse(Console.ReadLine());
            if (sexo.Equals('F'))
            {
                pulsaciones = (220 - edad) / 10;
            }
            else
            {
                pulsaciones = (210 - edad) / 10;
            }
            Console.WriteLine("Las pulsaciones son: " + pulsaciones);
            Console.ReadKey();
        }
    }
}
