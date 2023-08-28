using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            String nombre;
            int numCuenta;
            double saldoApertura;
            double consignacion;
            double retiro;
            double Saldo=0;
            int OP;

            //Solicitud de datos
            Console.WriteLine("¿Cual es el nombre del Cliente? ");
            nombre = Console.ReadLine();
            Console.WriteLine("Numero de cuenta: ");
            numCuenta = int.Parse(Console.ReadLine());
            Console.WriteLine("Saldo de apertura: ");
            saldoApertura = double.Parse(Console.ReadLine());
            Saldo = saldoApertura;

            Console.WriteLine("Que desea realizar?");
            Console.WriteLine("1. Consignar. ");
            Console.WriteLine("2. Retirar. ");
            Console.WriteLine("3. Consultar saldo. ");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opcion: ");
            OP = int.Parse(Console.ReadLine());

            if (OP == 1)
            {
                Console.Clear();
                Console.WriteLine("Cuanto desea Consignar?");
                consignacion = double.Parse(Console.ReadLine());
                Saldo = saldoApertura + consignacion;
                Console.WriteLine("Su consignacion se ha hecho con éxito");
                Console.ReadKey();
            }
            else
            {
                if (OP == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Cuanto desea retirar?");
                    retiro = double.Parse(Console.ReadLine());
                    Saldo -= retiro;
                    Console.ReadKey ();
                }
                else { if (OP == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Su saldo es: " + Saldo);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}