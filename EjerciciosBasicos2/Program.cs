using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double notaFinal = 0;

            // Solicitud de datos
            Console.Write("Escriba la Nota 1= ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Escriba la Nota 2= ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Escriba la Nota 3= ");
            nota3 = double.Parse(Console.ReadLine());

            // Ecuacion para encontrar la nota final
            notaFinal = (((nota1 * 30) / 100) + ((nota2 * 30) / 100) + ((nota3 * 40) / 100));

            //Se muestra la nota final
            Console.WriteLine("La nota Final es = " + notaFinal);

            // Se muestra en consols si ganó o perdió
            if (notaFinal < 3.0)
            {
                Console.Write("Lo lamento, Perdiste");
            }
            else
            {
                Console.Write("¡Felicidades!, Ganaste");
            }

            Console.ReadKey();
        }
    }
}