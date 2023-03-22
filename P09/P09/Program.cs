using Practica9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Caminar();
            p.CapturarDatos();
            p.MostrarDatos();

            Empleado em = new Empleado();
            em.CapturarDatos();
        }
    }
}
