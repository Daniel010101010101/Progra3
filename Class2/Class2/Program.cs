using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        class Persona
        {
            public string nombre;
            public int edad;
            public double peso;
            public double altura;

            void Comer()
            {
                Console.WriteLine("Puedo Comer");
            }

            void Caminar()
            {
                Console.WriteLine("Puedo Caminar");
            }
        }

        
    }
}
