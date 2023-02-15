using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "Daniel";
            Console.WriteLine(p.nombre);
            p.Caminar();
            p.Comer();


            Estudiante estudiante = new Estudiante();
            estudiante.nombre = "Daniel Tejada";
            WriteLine(estudiante.nombre);
            estudiante.Aprendo();
            ReadKey();
        }
        class Persona
        {
            public string nombre;
            public int edad;
            public double peso;
            public double altura;

            private string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public void Comer()
            {
                Console.WriteLine("Puedo Comer");
            }

            public void Caminar()
            {
                Console.WriteLine("Puedo Caminar");
            }
            
        }

        class Estudiante : Persona
        {
            public void Aprendo()
            {
                WriteLine("Yo aprendo programación");
            }
        }
        
        

        
    }
}
