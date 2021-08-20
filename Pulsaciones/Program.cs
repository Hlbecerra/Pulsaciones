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
            int Edad, Pulsaciones;

            do
            {
                Console.WriteLine("Digite el sexo (F/M): ");
                Sexo = char.Parse(Console.ReadLine());
            } while (Sexo != 'f' && Sexo != 'F' && Sexo != 'm' && Sexo != 'M');
            Console.WriteLine("Digite su edad: ");
            Edad = int.Parse(Console.ReadLine());

            if (Sexo == 'f' || Sexo == 'F')
            {
                Pulsaciones = (220 - Edad) / 10;
            }
            else if (Sexo == 'm' || Sexo == 'M')
            {
                Pulsaciones = (210 - Edad) / 10;
            }

            Console.WriteLine("Las pulsaciones por cada 10s son: {0}", Pulsaciones);
            Console.ReadKey();
        }
    }
}
