using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta venta = new Venta();
            venta.Compra();

        }
    }
}

public abstract class Bebida
{
    public string nombreBebida { get; set; }
    public string tipo { get; set; }
    public string categoria { get; set; }
    public string preparacion { get; set; }
    public string nombreCliente { get; set; }
    public int  edad { get; set; }
    public string  empleado { get; set; }
    
}

public class Venta : Bebida
{
    public Venta(string nombreBebida, string tipo, string categoria, string nombreCliente, int edad, string empleado, string preparacion)
    {
        this.nombreBebida = nombreBebida;
        this.tipo = tipo;
        this.categoria = categoria;
        this.nombreCliente = nombreCliente;
        this.edad = edad;
        this.empleado = empleado;
        this.preparacion = preparacion;
    }

    public Venta()
    {
    }

    public void Compra()
    {
        int opc;
        do
        {
            WriteLine("Bienvenido");
            WriteLine("Selecciona una opcion");
            WriteLine("1. Café \t 2. Soda \t 3. Cerveza \t 4. Tequila");
            opc = int.Parse(ReadLine());
            if (opc == 1)
            { 
                Clear();
                WriteLine("Haz seleccionado Café"); 
                WriteLine("\nIngresa tu nombre: ");
                nombreCliente = ReadLine();
                WriteLine("\nIngresa tu edad: ");
                edad = int.Parse(ReadLine());
                Clear();
                WriteLine("****Hora de realizar tu orden****");
                empleado = "Jesse Pinkman";
                WriteLine("\nEstas siendo atendido por: " + empleado);
                WriteLine("\n****Haz comprado un Café****");
                nombreBebida = "Café";
                categoria = "Cafeina";
                tipo = "Café negro";
                preparacion = "Herver";
                WriteLine("\n****Factura****" +
                          "\nNombre del cliente: " + nombreCliente +
                          "\nEdad del cliente: " + edad +
                          "\nNombre de la bebida: " + nombreBebida + 
                          "\nCategoría: " + categoria + 
                          "\nTipo: " + tipo +
                          "\nPreparación: "+ preparacion +
                          "\nTOTAL: 3.50 $$$$");
                WriteLine("\n1. Continuar \t 2. Volver al menu principal");
                int opc2 = int.Parse(ReadLine());
                if (opc2 == 1)
                {
                    WriteLine("Tu compra fue realizada con exito, Muchas gracias!!!");
                }
                else
                {
                    Clear();
                    Compra();
                }
                
                break;
                

            }
            if (opc == 2)
            {
                Clear();
                WriteLine("Haz seleccionado Soda"); 
                WriteLine("\nIngresa tu nombre: ");
                nombreCliente = ReadLine();
                WriteLine("\nIngresa tu edad: ");
                edad = int.Parse(ReadLine());
                Clear();
                WriteLine("****Hora de realizar tu orden****");
                empleado = "Phillip Brown";
                WriteLine("\nEstas siendo atendido por: " + empleado);
                WriteLine("\n****Haz comprado una Soda****");
                nombreBebida = "Coca-Cola";
                categoria = "Soda";
                tipo = "Gaseosa";
                preparacion = "No se";
                WriteLine("\n****Factura****" +
                          "\nNombre del cliente: " + nombreCliente +
                          "\nEdad del cliente: " + edad +
                          "\nNombre de la bebida: " + nombreBebida + 
                          "\nCategoría: " + categoria + 
                          "\nTipo: " + tipo +
                          "\nPreparación: "+ preparacion +
                          "\nTOTAL: 1.50 $$$$");
                WriteLine("\n1. Continuar \t 2. Volver al menu principal");
                int opc3 = int.Parse(ReadLine());
                if (opc3 == 1)
                {
                    WriteLine("Tu compra fue realizada con exito, Muchas gracias!!!");
                }
                else
                {
                    Clear();
                    Compra();
                }
                break;
            }
            if (opc == 3)
            {
                Clear();
                WriteLine("Haz seleccionado Cerveza"); 
                WriteLine("\nIngresa tu nombre: ");
                nombreCliente = ReadLine();
                WriteLine("\nIngresa tu edad: ");
                edad = int.Parse(ReadLine());
                if (edad < 18)
                {
                    WriteLine("No puedes comprar bebidas embriagantes porque eres menor  de edad");
                }
                else
                {
                    Clear();
                    WriteLine("****Hora de realizar tu orden****");
                    empleado = "Sr. White";
                    WriteLine("\nEstas siendo atendido por: " + empleado);
                    WriteLine("\n****Haz comprado una Cerveza****");
                    nombreBebida = "Pilsener";
                    categoria = "Alcohol";
                    tipo = "Cerveza";
                    preparacion = "En lata";
                    WriteLine("\n****Factura****" +
                              "\nNombre del cliente: " + nombreCliente +
                              "\nEdad del cliente: " + edad +
                              "\nNombre de la bebida: " + nombreBebida + 
                              "\nCategoría: " + categoria + 
                              "\nTipo: " + tipo +
                              "\nPreparación: "+ preparacion +
                              "\nTOTAL: 2.50 $$$$");
                    WriteLine("\n1. Continuar \t 2. Volver al menu principal");
                    int opc3 = int.Parse(ReadLine());
                    if (opc3 == 1)
                    {
                        WriteLine("Tu compra fue realizada con exito, Muchas gracias!!!");
                    }
                    else
                    {
                        Clear();
                        Compra();
                    }
                }
                break;
            }
            if (opc == 4)
            {
                Clear();
                WriteLine("Haz seleccionado Tequila"); 
                WriteLine("\nIngresa tu nombre: ");
                nombreCliente = ReadLine();
                WriteLine("\nIngresa tu edad: ");
                edad = int.Parse(ReadLine());
                if (edad < 18)
                {
                    WriteLine("No puedes comprar bebidas embriagantes porque eres menor  de edad");
                }
                else
                {
                    Clear();
                    WriteLine("****Hora de realizar tu orden****");
                    empleado = "Saul Goodman";
                    WriteLine("\nEstas siendo atendido por: " + empleado);
                    WriteLine("\n****Haz comprado Tequila****");
                    nombreBebida = "Vodka";
                    categoria = "Alcohol";
                    tipo = "Tequila";
                    preparacion = "Conservación";
                    WriteLine("\n****Factura****" +
                              "\nNombre del cliente: " + nombreCliente +
                              "\nEdad del cliente: " + edad +
                              "\nNombre de la bebida: " + nombreBebida + 
                              "\nCategoría: " + categoria + 
                              "\nTipo: " + tipo +
                              "\nPreparación: "+ preparacion +
                              "\nTOTAL: 20.00 $$$$");
                    WriteLine("\n1. Continuar \t 2. Volver al menu principal");
                    int opc3 = int.Parse(ReadLine());
                    if (opc3 == 1)
                    {
                        WriteLine("Tu compra fue realizada con exito, Muchas gracias!!!");
                    }
                    else
                    {
                        Clear();
                        Compra();
                    }
                }
                break;
            }
            
        } while (opc <= 4);
    }
    
}