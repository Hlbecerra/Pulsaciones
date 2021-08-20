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
            char Sexo;
            int Edad;
            int Pulsaciones;
            Console.WriteLine("Digite el sexo (F/M): ");
            Sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite la edad");
            Edad = int.Parse(Console.ReadLine());
            if (Sexo.Equals('F'))
            {
                Pulsaciones = (220 - Edad) / 10;
            }
            else
            {
                Pulsaciones = (210 - Edad) / 10;
            }
            Console.WriteLine("Las pulsaciones son: " + Pulsaciones);
            Console.ReadKey();
        }
    }
}
