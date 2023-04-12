using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Lab2
{
    class Areas
    {
        Empleado empleado = new Empleado();


        public void Area()
        {
            WriteLine("Bienvenido al Super Mercado");

            Empleado empleado = new Empleado();
            WriteLine("\nIngresa tu email");
            empleado.Email = ReadLine();
            WriteLine("\nIngresa tu password");
            empleado.Password = ReadLine();
            if (empleado.Email.Equals("admin") && empleado.Password.Equals("123"))
            {
                Clear();
                WriteLine("Bienvenido Administrador");

                WriteLine("\n¿Qué area deseas explorar?");
                WriteLine("\n1.Carnes");
                WriteLine("\n2.Bebidas");
                empleado.Area1= int.Parse(ReadLine());
                if (empleado.Area1 == 1)
                {
                    Clear();
                    WriteLine("Bienvenido al Area de Carnes");
                    WriteLine("\nSelecciona una categoria");
                    WriteLine("1.Carnes Magras");
                    WriteLine("2.Carnes Rojas");
                    WriteLine("3.Carnes Blancas");
                    empleado.Cat1= int.Parse(ReadLine());
                    if (empleado.Cat1 == 1)
                    {
                        Clear();
                        WriteLine("1.Filete");
                        WriteLine("2.Bistec");
                        WriteLine("\n1.Agregar Producto\t2.Venta");
                    }
                    else if (empleado.Cat1 == 2)
                    {
                        Clear();
                        WriteLine("1.Res");
                        WriteLine("2.Lomo");
                        WriteLine("\n1.Agregar Producto\t2.Venta");
                    }
                    else if (empleado.Cat1 == 3)
                    {
                        Clear();
                        WriteLine("1.Pollo");
                        WriteLine("2.Conejo");
                        WriteLine("\n1.Agregar Producto\t2.Venta");
                    }
                    
                }else if(empleado.Area1 == 2)
                {
                    Clear();
                    WriteLine("Bienvenido al Area de Bebidas");
                    WriteLine("\nSelecciona una categoria");
                    WriteLine("1.Soda");
                    WriteLine("2.Energisante");
                    WriteLine("3.Alcohol");
                    empleado.Cat1 = int.Parse(ReadLine());
                    if (empleado.Cat1 == 1)
                    {
                        Clear();
                        WriteLine("1.Coca-Cola");
                        WriteLine("2.Pepsi");
                        WriteLine("\n1.Agregar Producto\t2.Venta");
                    }
                    else if (empleado.Cat1 == 2)
                    {
                        Clear();
                        WriteLine("1.Monster");
                        WriteLine("2.Red Bull");
                        WriteLine("\n1.Agregar Producto\t2.Venta");
                    }
                    else if (empleado.Cat1 == 3)
                    {
                        Clear();
                        WriteLine("1.Vodka");
                        WriteLine("2.Wisky");
                        WriteLine("\n1.Agregar Producto\t2.Venta");
                    }
                }
               

            }
            else if (empleado.Email.Equals("user") && empleado.Password.Equals("321"))
            {
                WriteLine("Bienvenido User");
                Clear();
                WriteLine("Bienvenido Administrador");

                WriteLine("\n¿Qué area deseas explorar?");
                WriteLine("\n1.Carnes");
                WriteLine("\n2.Bebidas");
                empleado.Area1 = int.Parse(ReadLine());
                if (empleado.Area1 == 1)
                {
                    Clear();
                    WriteLine("Bienvenido al Area de Carnes");
                    WriteLine("\nSelecciona una categoria");
                    WriteLine("1.Carnes Magras");
                    WriteLine("2.Carnes Rojas");
                    WriteLine("3.Carnes Blancas");
                    empleado.Cat1 = int.Parse(ReadLine());
                    if (empleado.Cat1 == 1)
                    {
                        Clear();
                        WriteLine("1.Filete");
                        WriteLine("2.Bistec");
                        WriteLine("\n1.Venta");
                    }
                    else if (empleado.Cat1 == 2)
                    {
                        Clear();
                        WriteLine("1.Res");
                        WriteLine("2.Lomo");
                        WriteLine("\n1.Venta");
                    }
                    else if (empleado.Cat1 == 3)
                    {
                        Clear();
                        WriteLine("1.Pollo");
                        WriteLine("2.Conejo");
                        WriteLine("\n1.Venta");
                    }

                }
                else if (empleado.Area1 == 2)
                {
                    Clear();
                    WriteLine("Bienvenido al Area de Bebidas");
                    WriteLine("\nSelecciona una categoria");
                    WriteLine("1.Soda");
                    WriteLine("2.Energisante");
                    WriteLine("3.Alcohol");
                    empleado.Cat1 = int.Parse(ReadLine());
                    if (empleado.Cat1 == 1)
                    {
                        Clear();
                        WriteLine("1.Coca-Cola");
                        WriteLine("2.Pepsi");
                        WriteLine("\n1.Venta");
                    }
                    else if (empleado.Cat1 == 2)
                    {
                        Clear();
                        WriteLine("1.Monster");
                        WriteLine("2.Red Bull");
                        WriteLine("\n1.Venta");
                    }
                    else if (empleado.Cat1 == 3)
                    {
                        Clear();
                        WriteLine("1.Vodka");
                        WriteLine("2.Wisky");
                        WriteLine("\n1.Venta"); ;
                    }
                }
            }
        }
    }
}
