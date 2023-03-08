using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practica7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Animal();
            WriteLine("Ingresa una raza: ");
            perro.Raza = ReadLine();
            WriteLine("Haz ingresado: " + perro.Raza);
            ReadKey();
        }
    }
}
