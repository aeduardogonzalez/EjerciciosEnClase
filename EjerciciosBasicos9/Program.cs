using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int pulsaciones = 0;
            int edad = 0;
            char sexo;

            //Solicitud de datos
            Console.WriteLine("Escriba la Edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cual es el Sexo? [M/F]: ");
            sexo = char.Parse(Console.ReadLine());

            // validacion de sexo y calculo de pulsaciones
            if (sexo == 'M' || sexo == 'm')
            {
                pulsaciones = (210 - edad) / 10;
            }
            else
            {
                pulsaciones = (220 - edad) / 10;
            }

            //Muestra de resultados
            Console.WriteLine("El numero de pulusaciones de la persona es: " + pulsaciones);

            Console.ReadKey();
        }
    }
}