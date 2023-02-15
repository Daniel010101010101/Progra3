using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersona[] persona= new IPersona[2];
            persona[0] = new Alumno("Jesse Pinkman");
            persona[1] = new Empleado("Walter White");

            for (int i = 0; i < persona.Length; i++)
            {
                WriteLine(persona[i].Despedirse());
            }
            ReadKey();
        }
    }
}

public interface IPersona
{
    string Despedirse();
}

public class Alumno2 : IPersona
{
    public Alumno2(string nombre)
    {
        this.Nombre = nombre;
    }

    public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string Despedirse()
    {
        string adios = "El alumno " + this.Nombre + " se despide";
        return adios;
    }

}

public abstract class Persona
{
    public  string Nombre { get; set;  }
    public abstract string Saludar();
}

public class Alumno : Persona, IPersona
{
    public Alumno(string nombre) 
    {
        this.Nombre = nombre;
    }

    public string Despedirse()
    {
        string adios = "El alumno " + this.Nombre + " se despide";
        return adios;
    }

    public override string Saludar()
    {
        string saludo = "Hola, mi nombre es: " + this.Nombre + " y soy alumno";
        return saludo;
    }
}

public class Empleado : Persona, IPersona
{
    public Empleado(string nombre)
    {
        this.Nombre = nombre;
    }

    public string Despedirse()
    {
        string adios = "El empleado " + this.Nombre + " se despide";
        return adios;
    }

    public override string Saludar()
    {
        string saludo = "Hola, mi nombre es: " + this.Nombre + " y soy empleado";
        return saludo;
    }

}
