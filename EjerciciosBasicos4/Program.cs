using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables 
            float num1=0;
            float num2=0;
            float resultado1 = 0;
            float resultado2 = 0;
            float resultado3 = 0;
            float resultado4 = 0;

            Console.WriteLine("Este es un programa que hace las operaciones matematicas entre 2 numeros");

            // Solicitar Numeros para realizar las operaciones 
            Console.WriteLine("Escriba el primer numero: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());

            // Realizar las operaciones y guardarlas en cada variable
            resultado1 = num1 + num2;
            resultado2 = num1 - num2;
            resultado3 = num1 * num2;
            resultado4 = num1 / num2;

            // Mostrar los resultados de las operaciones
            Console.WriteLine("La suma de los numeros es: " + resultado1);
            Console.WriteLine("La resta de los numeros es: " + resultado2);
            Console.WriteLine("La multiplicacion de los numeros es: " + resultado3);
            Console.WriteLine("La division de los numeros es: " + resultado4);

            Console.ReadKey();
        }
    }
}