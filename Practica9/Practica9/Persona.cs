using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practica9
{
     class Persona
     {
        string nombre;
        string apellido;
        string sexo;
        int edad;

        public void Caminar()
        {
            WriteLine("Esta persona camina con flow");
            ReadKey();
        }
        public void CapturarDatos()
        {
            nombre = ReadLine();
            apellido = ReadLine();
            sexo = ReadLine();
            edad = int.Parse(ReadLine());
        }
        public void MostrarDatos()
        {
            WriteLine($"Nombre: {nombre}");
            WriteLine($"Apellido: {apellido}");
            WriteLine($"Sexo: {sexo}");
            WriteLine($"Edad: {edad}");
        }
     }
    
}
