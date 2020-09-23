using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary;

namespace Consola.Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.Write("Hola");
            Console.WriteLine("Esto trae un salto de línea");
            Console.WriteLine(i);
            Console.ReadKey();

            ClaseDeLaLibreria variable = new ClaseDeLaLibreria();
        }
    }
}
