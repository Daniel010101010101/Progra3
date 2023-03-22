using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practica9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Caminar();
            p.CapturarDatos();
            p.MostrarDatos();
        }
    }
}
