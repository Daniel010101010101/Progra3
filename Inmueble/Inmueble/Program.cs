using System;
using static System.Console;

namespace Inmueble
{
    class Program
    {
        public abstract class Inmueble
        {
            protected double precioVenta;
            protected string nombreProducto;
            protected string Name;
            protected string Lastname;
            protected string Contrato;
            public Inmueble(string nombre, double precio)
            {
                nombreProducto = nombre;
                precioVenta = precio;
            }
            public Inmueble(string name, string lastname)
            {
                Name = name;
                Lastname = lastname;
            }

            public Inmueble(string contrato)
            {
                Contrato = contrato;
            }
            public abstract string imprimirDatos();
        }
        public class Cliente : Inmueble
        {
            public Cliente(string name, string lastname)
                :base(name,lastname)
            {

            }
            public override string imprimirDatos()
            {
                return "Bienvenido " + Name + " " + Lastname;
            }
        }

        public class Contrato : Inmueble
        {
            public Contrato(string contrato) : base(contrato)
            {
                
            }

            public override string imprimirDatos()
            {
                
                return
                    
                    "Contrato: Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. " +
                    "\nProin venenatis turpis sit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. " +
                    "\nNunc luctus, tortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros. " + "\nTu compra fue realizada con Exito"+ " " + "\nBuen dia :)"
                     + Name + " " + Lastname;
            }
        }

        public class Casa : Inmueble
        {
            public Casa(string nombre, double precio )
                : base(nombre, precio)
            {
                

            }
            public override string imprimirDatos()
            {
                return "Nombre: " + nombreProducto + "\nPrecio: " + precioVenta;
            }
        }
        public class Apartamento : Inmueble
        {
            public Apartamento(string nombre, double precio )
                : base(nombre, precio)
            {
                

            }
            public override string imprimirDatos()
            {
                return "Nombre: " + nombreProducto + "\nPrecio: " + precioVenta;
            }
        }
        class Program1
        {
            static void Main(string[] args)
            {
               
                int opciones;
                WriteLine("Selecciona una opcion: ");
                WriteLine("1- Casa");
                WriteLine("2- Apartamento");
                opciones = int.Parse(ReadLine());
                Clear();
                switch (opciones)
                {
                    
                    case 1:
                        int opcion;
                        WriteLine("¿Quien quieres que te atienda? ");
                        WriteLine("1- Jesse Pinkman");
                        WriteLine("2- Walter White");
                        opcion = int.Parse(ReadLine());
                        Clear();

                        switch (opcion)
                        {
                            case 1:
                                int opcioncasa;
                                WriteLine("Estas siendo atendido por Jesse Pinkman");
                                WriteLine("Ingresa tu nombre: ");
                                string name = ReadLine();
                                WriteLine("Ingresa tu apellido: ");
                                string lastname = ReadLine();
                                Clear();
                                Cliente cliente = new Cliente(name,lastname);
                                WriteLine(cliente.imprimirDatos());
                                WriteLine("\nCasa Disponible: ");
                                Casa casa = new Casa("Casa bonita",150000.000);
                                WriteLine(casa.imprimirDatos());
                                WriteLine("\n¿Deseas Continuar?");
                                WriteLine("1- Si");
                                WriteLine("2- No");
                                
                                opcioncasa = int.Parse(ReadLine());
                                switch (opcioncasa)
                                {
                                    case 1:
                                        Contrato contrato = new Contrato(
                                            "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. Proin venenatis turpis " +
                                            "\nsit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. Nunc luctus, " +
                                            "\ntortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros");
                                        WriteLine(contrato.imprimirDatos());
                                        break;
                                    case 2:
                                        Environment.Exit(0);
                                        break;
                                   
                                        
                                }
                                break;
                            case 2:
                                int opcioncasa1;
                                WriteLine("Estas siendo atendido por Walter White");
                                WriteLine("Ingresa tu nombre: ");
                                string name1 = ReadLine();
                                WriteLine("Ingresa tu apellido: ");
                                string lastname1 = ReadLine();
                                Clear();
                                Cliente cliente1 = new Cliente(name1,lastname1);
                                WriteLine(cliente1.imprimirDatos());
                                WriteLine("\nCasa Disponible: ");
                                Casa casa1 = new Casa("Casa bonita",150000.000);
                                WriteLine(casa1.imprimirDatos());
                                WriteLine("\n¿Deseas Continuar?");
                                WriteLine("1- Si");
                                WriteLine("2- No");
                                
                                opcioncasa1 = int.Parse(ReadLine());
                                switch (opcioncasa1)
                                {
                                    case 1:
                                        Contrato contrato = new Contrato(
                                            "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. Proin venenatis turpis " +
                                            "\nsit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. Nunc luctus, " +
                                            "\ntortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros");
                                        WriteLine(contrato.imprimirDatos());
                                        break;
                                    case 2:
                                        Environment.Exit(0);
                                        break;
                                   
                                        
                                }
                                break;


                        }
                        break;
                    case 2:
                        int opcion2;
                        WriteLine("¿Quien quieres que te atienda? ");
                        WriteLine("1- Jesse Pinkman");
                        WriteLine("2- Walter White");
                        opcion2 = int.Parse(ReadLine());
                        Clear();

                        switch (opcion2)
                        {
                            case 1:
                                int opcionApartamento;
                                WriteLine("Estas siendo atendido por Jesse Pinkman");
                                WriteLine("Ingresa tu nombre: ");
                                string name = ReadLine();
                                WriteLine("Ingresa tu apellido: ");
                                string lastname = ReadLine();
                                Clear();
                                Cliente cliente = new Cliente(name,lastname);
                                WriteLine(cliente.imprimirDatos());
                                WriteLine("\nApartamento Disponible");
                                Apartamento apartamento1 = new Apartamento("Apartamento bonit0",120000.000);
                                WriteLine(apartamento1.imprimirDatos());
                                WriteLine("\n¿Deseas Continuar?");
                                WriteLine("1- Si");
                                WriteLine("2- No");
                                
                                opcionApartamento = int.Parse(ReadLine());
                                switch (opcionApartamento)
                                {
                                    case 1:
                                        Contrato contrato = new Contrato(
                                            "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. Proin venenatis turpis " +
                                            "\nsit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. Nunc luctus, " +
                                            "\ntortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros");
                                        WriteLine(contrato.imprimirDatos());
                                        break;
                                    case 2:
                                        Environment.Exit(0);
                                        break;
                                   
                                        
                                }
                                break;
                            case 2:
                                int opcionApartamento1;
                                WriteLine("Estas siendo atendido por Walter White");
                                WriteLine("Ingresa tu nombre: ");
                                string name1 = ReadLine();
                                WriteLine("Ingresa tu apellido: ");
                                string lastname1 = ReadLine();
                                Clear();
                                Cliente cliente1 = new Cliente(name1,lastname1);
                                WriteLine(cliente1.imprimirDatos());
                                WriteLine("\nApartamento Disponible: ");
                                Apartamento apartamento = new Apartamento("Aparamento bonito",120000.000);
                                WriteLine(apartamento.imprimirDatos());
                                WriteLine("\n¿Deseas Continuar?");
                                WriteLine("1- Si");
                                WriteLine("2- No");
                                
                                opcionApartamento1 = int.Parse(ReadLine());
                                switch (opcionApartamento1)
                                {
                                    case 1:
                                        Contrato contrato = new Contrato(
                                            "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. Proin venenatis turpis " +
                                            "\nsit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. Nunc luctus, " +
                                            "\ntortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros");
                                        WriteLine(contrato.imprimirDatos());
                                        break;
                                    case 2:
                                        Environment.Exit(0);
                                        break;
                                   
                                        
                                }
                                break;


                        }
                        break;
                        break;
                        
                }
            }
        }
    }
}