using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            float precio = 0;
            float impuesto = 0;
            float totalPrecio = 0;
            String producto;

            // Solicitud de Datos
            Console.WriteLine("¿Que producto desea Comprar? :");
            producto = Console.ReadLine();
            Console.WriteLine("¿Cual es el precio del producto? :");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cual es el impuesto que se le aplicará al producto? :");
            impuesto = float.Parse(Console.ReadLine());

            // Ecuacion para calcular el precio total del producto que se va a comprar
            totalPrecio = precio + (precio * (impuesto/100));

            // Se muestran los resultados
            Console.WriteLine("El precio total del producto es: " + totalPrecio);

            Console.ReadKey();

        }
    }
}