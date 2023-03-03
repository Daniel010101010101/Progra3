using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        int opc;
        WriteLine("Seleccione una opcion");
        WriteLine("1.Camisas");
        WriteLine("2.Pantalones");
        opc = int.Parse(ReadLine());

        if (opc == 1)
        {
            
            Clear();
            Prendas camisa = new Camisa("Alta", "Casual | Elegante", new string[] { "M","S","L"}, "Larga | Corta");
            

            //Prendas pantalon = new Pantalon("Media", "Casual", new string[] { "M", "L", "XL", "XXL" }, "Fino");

            Prendas[] prendas = new Prendas[] { camisa};

            foreach (Prendas prenda in prendas)
            {
                prenda.MostrarPrenda();
                
            }
            
            
        }
        if (opc == 2)
        {
            Clear();
            //Prendas camisa = new Camisa("Alta", "\tCasual", new string[] { "S", "M", "L" }, "Manga larga");

            Prendas pantalon = new Pantalon("Alta", "Casual | Elegante", new string[] { "M", "L", "XL", "XXL" }, "Fino | Casual");

            Prendas[] prendas = new Prendas[] { pantalon };
            foreach (Prendas prenda in prendas)
            {
                prenda.MostrarPrenda();

            }
        }
        
    }
}

abstract class Prendas
{
    protected string calidad;
    protected string diseno;
    protected string[] talla;

    public Prendas(string calidad, string diseno, string[] talla)
    {
        this.calidad = calidad;
        this.diseno = diseno;
        this.talla = talla;
    }
    public abstract void MostrarPrenda();
}
class Camisa : Prendas
{
    private string tipoManga;

    public Camisa(string calidad, string diseno, string[] talla, string tipoManga) : base(calidad, diseno, talla)
    {
        this.tipoManga = tipoManga;
    }

    public override void MostrarPrenda()
    {
        PreguntarCalidad();
        ReadKey();
    }

    public  void PreguntarCalidad()
    {
        int opc;
        WriteLine("Selecciona la calidad que deseas");
        WriteLine("1.Alta");
        WriteLine("2.Baja");
        opc = int.Parse(ReadLine());
        if (opc == 1)
        {
            Clear();
            WriteLine("\nHaz seleccionado camisa de " + calidad + " calidad");
            WriteLine("\nAhora se muestra un catalogo de camisas de " + calidad + " calidad");
            WriteLine("\nCamisa de " + calidad + " calidad, diseño " + diseno + ", tallas disponibles: " + string.Join(", ", talla) + ", estilo: " + tipoManga);
            WriteLine("Gracias por su visita :)");

  
        }
        else
        {
            WriteLine("Lo sentimos " +
                      "\nERROR 404! " +
                      "\nEn este momento no tenemos esas prendas disponibles " +
                      "\nPor Favor intentalo mas tarde :)");
        }
    }

    
}

class Pantalon : Prendas
{
    private string estilo;

    public Pantalon(string calidad, string diseno, string[] talla, string estilo) : base(calidad, diseno, talla)
    {
        this.estilo = estilo;
    }

    public override void MostrarPrenda()
    {
        PreguntarCalidad();
        ReadKey();
    }
    public  void PreguntarCalidad()
    {
        int opc;
        WriteLine("Selecciona la calidad que deseas");
        WriteLine("1.Alta");
        WriteLine("2.Baja");
        opc = int.Parse(ReadLine());
        if (opc == 1)
        {
            Clear();
            WriteLine("\nHaz seleccionado pantalon de " + calidad + " calidad");
            WriteLine("\nAhora se muestra un catalogo de pantalones de " + calidad + " calidad");
            WriteLine("\nPantalon de " + calidad + " calidad, diseño " + diseno + ", tallas disponibles: " + string.Join(", ", talla) + ", estilo: " + estilo);
            WriteLine("Gracias por su visita :)");
        }
        else
        {
            WriteLine("Lo sentimos " +
                      "\nERROR 404! " +
                      "\nEn este momento no tenemos esas prendas disponibles " +
                      "\nPor Favor intentalo mas tarde :)");
        }
    }

}


