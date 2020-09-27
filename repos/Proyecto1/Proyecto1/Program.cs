using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1.";
            Console.WriteLine(Console.Title);

            int totalNumeroALeer = 5;
            int num;
            string lectura;
            int max = int.MinValue; //le ponemos el int más chico que existe, así cualquier valor que cargue la primera vez
            int min = int.MaxValue; //es es más grande que el MinValue y se va a guardar en el max y si es el MinValue
            float promedio = 0;     //mi max va a seguir siendo el MinValue.
            int acumulador = 0;
            int cantidad = 0;

            for(int i = 0; i < totalNumeroALeer; i++)
            {
                Console.WriteLine("Ingrese un número:");
                lectura = Console.ReadLine();
                if (int.TryParse(lectura, out num)) //recibe lo q quiero convertir, un string (chequea si ese string contiene algo convertible a entero)  // num = int.Parse(Console.ReadLine());
                {                                     //y a dónde lo quiero guardar. Si cargaste una "a" lo descarta, si cargaste un num válido
                    if (num > max)                    //lo convierte y devuelve TRUE si no FALSE.
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                    acumulador += num;         // promedio = (promedio + num); LOS ACUMULA
                    cantidad++;
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido.");
                    i--;
                }
            }
            promedio = acumulador / cantidad;  // promedio = promedio / totalNumeroALeer

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Máx: {0,1}", max);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Min: {0,1}", min);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Prom: {0,1}", promedio);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Máximo: {0,3} - Mínimo: {1,3} - Promedio: {2,5:#,###.00}", max, min, promedio);
            Console.ReadKey();

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Máximo: {0,3} - Mínimo: {1,3} - Promedio: {2,5:#,###.00}", max, min, promedio);
            Console.ReadKey();

        }
    }
}
