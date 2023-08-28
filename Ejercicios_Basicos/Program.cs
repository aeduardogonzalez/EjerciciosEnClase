using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            float baseTriangulo = 0;
            float alturaTriangulo = 0;
            float areaTriangulo = 0;

            // Solicitud de datos
            Console.Write("Base=");
            baseTriangulo = int.Parse(Console.ReadLine());

            Console.Write("Altura=");
            alturaTriangulo = int.Parse(Console.ReadLine());

            // Ecuacion para calcular el area de un triangulo
            areaTriangulo = baseTriangulo*alturaTriangulo/2;

            // Se muestra el resultado del area del triangulo
            Console.WriteLine("El Area del Triangulo es = " + areaTriangulo.ToString());

            Console.ReadKey();
        }
    }
}