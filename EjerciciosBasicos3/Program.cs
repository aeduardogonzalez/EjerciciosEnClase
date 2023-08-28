using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            String nombre;
            long cedula = 0;
            String sexo;

            // Se solicitan los datos
            Console.WriteLine("¿Cual es su nombre?: ");
            nombre = Console.ReadLine();

            Console.WriteLine("¿Cual es su cedula?: ");
            cedula = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("¿Cual es su sexo?: ");
            sexo = Console.ReadLine();

            //Se muestran los datos
            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu # de cedula es: " + cedula);
            Console.WriteLine("Eres de sexo: " + sexo);

            Console.ReadKey();
        }
    }
}