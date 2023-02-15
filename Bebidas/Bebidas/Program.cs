using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebida[] bebida = new Bebida[5];

            bebida[0] = new Venta("Soda" + "A mano" + "Alcohol" + 12 + " " + " ");
        }
    }
}
public abstract class Bebida
{
    public string NombreBebida { get; set; }
    public string Preparacion { get; set; }
    public string NombrePersona { get; set; }
    public int edad { get; set; }
    public string Categoria { get; set; }
    public string empleado { get; set; }

    public abstract string Vender();
}

public class Venta : Bebida
{
    
    public  Venta(string nombreBedida, string preparacion, string nombrepersona, int edad, string categoria, string empleado)
    {
        this.NombreBebida = nombreBedida;
        this.Preparacion = preparacion;
        this.Categoria = categoria;
    }
    public override string Vender()
    {
        string dato = "Bienvenido " + this.NombrePersona;
        return dato;
    }

}