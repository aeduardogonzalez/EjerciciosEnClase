using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            Console.WriteLine("INGRESE DATOS DE LA MATRIZ 3X3");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(3 + j * 3, 3 + i + 2); matriz[i, j] = int.Parse(Console.ReadLine());

                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        Console.SetCursorPosition(15 + j * 3, 3 + i + 2);
                        Console.WriteLine(matriz[i, j]);

                    }

                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i > j)
                    {
                        Console.SetCursorPosition(35 + j * 3, 3 + i + 2);
                        Console.WriteLine(matriz[i, j]);

                    }

                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i <= j)
                    {
                        Console.SetCursorPosition(55 + j * 3, 3 + i + 2);
                        Console.WriteLine(matriz[i, j]);

                    }

                }

            }
            Console.ReadKey();
        }
    }
}