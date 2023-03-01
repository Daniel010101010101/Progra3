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
        opc = int.Parse(Console.ReadLine());

        if (opc == 1)
        {
            Clear();
            Prendas camisa = new Camisa("Alta | Baja", "Casual | Elegante", new string[] { "S", "M", "L" }, "Manga larga | Manga corta | Polo Sport");

            //Prendas pantalon = new Pantalon("Media", "Casual", new string[] { "M", "L", "XL", "XXL" }, "Fino");

            Prendas[] prendas = new Prendas[] { camisa};

            WriteLine("Catálogo de camisas por calidad:\n");

            foreach (Prendas prenda in prendas)
            {
                prenda.MostrarPrenda();

            }
        }
        if (opc == 2)
        {
            Clear();
            //Prendas camisa = new Camisa("Alta", "\tCasual", new string[] { "S", "M", "L" }, "Manga larga");

            Prendas pantalon = new Pantalon("Media | Alta", "Casual | Elegante", new string[] { "M", "L", "XL", "XXL" }, "Fino | Casual");

            Prendas[] prendas = new Prendas[] { pantalon };

            WriteLine("Catálogo de pantalones por calidad:\n");

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
        WriteLine("\nCamisa de " + calidad + "\tcalidad, \tdiseño " + diseno + ", \ttallas disponibles: " + string.Join(", ", talla) + ", \ttipo de manga: " + tipoManga);
        WriteLine("\nGracias Por su visita :)");
        ReadKey();
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
        WriteLine("\nPantalón de " + calidad + " calidad, diseño " + diseno + ", tallas disponibles: " + string.Join(", ", talla) + ", estilo: " + estilo);
        WriteLine("\nGracias Por su visita :)");
        ReadKey();
    }
}


