using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class Program
{
    statics void Main(string[] args)
    {
        // Definir tiendas
        string[] tiendas = { "Tienda 1", "Tienda 2", "Tienda 3" };

        // Mostrar tiendas
        Console.WriteLine("Elija una tienda:");

        for (int i = 0; i < tiendas.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {tiendas[i]}");
        }

        // Obtener selección del usuario
        int tiendaSeleccionada = int.Parse(Console.ReadLine());

        // Mostrar catálogo de zapatos para hombres y mujeres
        Console.WriteLine($"Catálogo de zapatos para {tiendas[tiendaSeleccionada - 1]}");

        // Zapatos para hombres
        Console.WriteLine("Zapatos para hombres:");
        Console.WriteLine("Estilo\t\tMarca\t\tTalla\t\tPrecio");

        Zapato zapatoHombre1 = new Zapato("Botas", "Nike", 9.5, 99.99);
        Zapato zapatoHombre2 = new Zapato("Zapatillas", "Adidas", 10, 79.99, 0.1);
        Zapato zapatoHombre3 = new Zapato("Sandalias", "Reef", 11, 49.99);

        Console.WriteLine(zapatoHombre1);
        Console.WriteLine(zapatoHombre2);
        Console.WriteLine(zapatoHombre3);

        // Zapatos para mujeres
        Console.WriteLine("Zapatos para mujeres:");
        Console.WriteLine("Estilo\t\tMarca\t\tTalla\t\tPrecio");

        Zapato zapatoMujer1 = new Zapato("Botines", "Steve Madden", 8, 149.99);
        Zapato zapatoMujer2 = new Zapato("Tacones", "Jessica Simpson", 7.5, 89.99, 0.2);
        Zapato zapatoMujer3 = new Zapato("Sandalias", "Birkenstock", 9, 79.99);

        Console.WriteLine(zapatoMujer1);
        Console.WriteLine(zapatoMujer2);
        Console.WriteLine(zapatoMujer3);

        Console.ReadLine();
    }
}

class Zapato
{
    // Atributos
    public string estilo;
    public string marca;
    public double talla;
    public double precio;
    public double descuento;

    // Constructor
    public Zapato(string estilo, string marca, double talla, double precio, double descuento = 0)
    {
        this.estilo = estilo;
        this.marca = marca;
        this.talla = talla;
        this.precio = precio;
        this.descuento = descuento;
    }

    // Método para obtener precio con descuento
    public double PrecioConDescuento()
    {
        return precio * (1 - descuento);
    }

    // Sobrecarga del método ToString para imprimir detalles del zapato
    public override string ToString()
    {
        return $"{estilo}\t\t{marca}\t\t{talla}\t\t{PrecioConDescuento()}";
    }
}

