using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string lectura;

            Console.Title = "Ejercicio Nro. 2.";
            Console.WriteLine(Console.Title);
            Console.WriteLine("Ingrese un número: ");
            lectura = Console.ReadLine();

            if (int.TryParse(lectura, out numero))
            {
                if (numero > 0)
                {
                    int elevadoAlCuadrado = (int)Math.Pow(numero, 2);
                    int elevadoAlCubo = (int)Math.Pow(numero, 3);
                    Console.WriteLine("El cuadrado del número: {0} es {1} - El cubo es {2}.", numero, elevadoAlCuadrado, elevadoAlCubo);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! debe ser mayor a CERO.");
                }

            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
            }
            Console.ReadKey();
        }

    }
}
