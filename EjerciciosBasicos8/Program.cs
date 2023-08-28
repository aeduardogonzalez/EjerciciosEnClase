using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cedula;
            double telefono;
            String nombre;
            String direccion;
            String sexo;
            String estado_civil;
            String titulo, titulo2;

            titulo2 = "DATOS PERSONALES";
            do
            {
                FuncionTitulo(titulo2);
                Console.SetCursorPosition(10, 9); Console.WriteLine("Digite su cedula:");
                Console.SetCursorPosition(10, 10); cedula = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.SetCursorPosition(10, 13); Console.WriteLine("Escribe bien tu cedula :)");
            } while (cedula <= 0);

            Console.SetCursorPosition(10, 13); Console.WriteLine("                                          ");

            FuncionTitulo(titulo2);
            Console.SetCursorPosition(10, 9); Console.WriteLine("Digite su nombre:");
            Console.SetCursorPosition(10, 10); nombre = Console.ReadLine();
            Console.Clear();

            FuncionTitulo(titulo2);
            Console.SetCursorPosition(10, 9); Console.WriteLine("Digite su direccion:");
            Console.SetCursorPosition(10, 10); direccion = Console.ReadLine();
            Console.Clear();

            do
            {
                FuncionTitulo(titulo2);
                Console.SetCursorPosition(10, 9); Console.WriteLine("Digite su numero telefonico:");
                Console.SetCursorPosition(10, 10); telefono = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.SetCursorPosition(10, 13); Console.WriteLine("Escribe bien tu numero de telefono :)");
            } while (telefono <= 0);

            Console.SetCursorPosition(10, 13); Console.WriteLine("                                          ");

            FuncionTitulo(titulo2);
            Console.SetCursorPosition(10, 9); Console.WriteLine("Digite su sexo:");
            Console.SetCursorPosition(10, 10); sexo = Console.ReadLine();
            Console.Clear();

            FuncionTitulo(titulo2);
            Console.SetCursorPosition(10, 9); Console.WriteLine("Digite su estado civil:");
            Console.SetCursorPosition(10, 10); estado_civil = Console.ReadLine();
            Console.Clear();

            titulo = "REGISTROS BASICOS";
            String tituloFormateado2 = $"**************** {titulo} ****************";
            Console.SetCursorPosition(10, 5); Console.WriteLine("".PadLeft(tituloFormateado2.Length, '='));
            Console.SetCursorPosition(10, 6); Console.WriteLine(tituloFormateado2);
            Console.SetCursorPosition(10, 7); Console.WriteLine("".PadLeft(tituloFormateado2.Length, '='));

            Console.SetCursorPosition(10, 9); Console.WriteLine("CEDULA:       " + cedula);
            Console.SetCursorPosition(10, 11); Console.WriteLine("NOMBRE:       " + nombre);
            Console.SetCursorPosition(10, 13); Console.WriteLine("DIRECCION:    " + direccion);
            Console.SetCursorPosition(10, 15); Console.WriteLine("TELEFONO:     " + telefono);
            Console.SetCursorPosition(10, 17); Console.WriteLine("SEXO:         " + sexo);
            Console.SetCursorPosition(10, 19); Console.WriteLine("ESTADO CIVIL: " + estado_civil);
            Console.ReadKey();
        }
        static void FuncionTitulo(string titulo2)
        {
            String tituloFormateado = $"**************** {titulo2} ****************";
            Console.SetCursorPosition(10, 5); Console.WriteLine("".PadLeft(tituloFormateado.Length, '='));
            Console.SetCursorPosition(10, 6); Console.WriteLine(tituloFormateado);
            Console.SetCursorPosition(10, 7); Console.WriteLine("".PadLeft(tituloFormateado.Length, '='));
        }
    }
}