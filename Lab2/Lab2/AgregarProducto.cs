using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab2
{
    class AgregarProducto
    {
        Empleado empleado = new Empleado();
        public void Agregar() 
        {
            List<string> lista = new List<string>();

            while (true)
            {
                Console.Write("Ingresa un elemento para agregar a la lista (o escribe 'salir' para terminar): ");
                string entrada = Console.ReadLine();
                if (entrada == "salir")
                {
                    break;
                }
                lista.Add(entrada);
                Console.WriteLine("Elemento agregado a la lista.");
            }

            Console.WriteLine("\nLa lista final es:");

            foreach (string elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
