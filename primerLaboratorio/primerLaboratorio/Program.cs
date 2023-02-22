using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace primerLaboratorio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User u = new User();
            u.IngresarDatos();
           
        }
    }
}
public abstract class Departamento
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public int edad { get; set; }
    public string departamento { get; set; }
    public string municipio { get; set; }
    

}
public class User:Departamento
{
    public User()
    {
    }

    public User(string nombre, string apellido, int edad, string departamento,string municipio)
    {
        this.nombre= nombre;
        this.apellido= apellido;
        this.edad= edad;
        this.departamento= departamento;
        this.municipio= municipio;
    }

    public void IngresarDatos()
    {
        int opc;

        do
        {
            WriteLine("Bienvenido");
            WriteLine("\nSelecciona una opción");
            WriteLine("\n1.Ingresar Datos \t2.Salir");
            opc = int.Parse(ReadLine());
            if (opc == 1)
            {
                Clear();
                WriteLine("Ingresa tu nombre: ");
                nombre= ReadLine();
                WriteLine("Ingresa tu apellido");
                apellido= ReadLine();
                WriteLine("Ingresa tu edad");
                edad = int.Parse(ReadLine());
                WriteLine("\nDatos ingresados: " + nombre +" "+ " "+apellido+" " + edad);
                WriteLine("\n1.Continuar \t 2.Salir");
                opc= int.Parse(ReadLine());
                if (opc == 1)
                {
                    int opc2;
                    Clear();
                    WriteLine("Selecciona un departamento");
                    WriteLine("1.Santa Ana" +
                        "\n2.Ahuachapán" +
                        "\n3.Sonsonate" +
                        "\n4.San Salvador" +
                        "\n5.La Libertad");
                    opc2= int.Parse(ReadLine());
                    if (opc2 == 1)
                    {
                        int opc3;
                        Clear();
                        WriteLine("Municipios de Santa Ana");
                        WriteLine("\n1.Candelaria de la Frontera " +
                            "\n2.Chalchuapa  " +
                            "\n3.El Congo " +
                            "\n4.Masahuat " +
                            "\n5.Metapán ");
                        opc3= int.Parse(ReadLine());
                        if (opc3 == 1)
                        {
                            departamento = "Santa Ana";
                            municipio = "Candelaria de la Frontera";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4= int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                            
                            
                        }
                        if (opc3 == 2)
                        {
                            departamento = "Santa Ana";
                            municipio = "Chalchuapa";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "Santa Ana";
                            municipio = "El Congo";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "Santa Ana";
                            municipio = "Masahuat";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "Santa Ana";
                            municipio = "Metapan";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                    }
                    if (opc2 == 2)
                    {
                        int opc3;
                        Clear();
                        WriteLine("Municipios de Ahuachapan");
                        WriteLine("\n1.Ahuachapán " +
                            "\n2.Apaneca " +
                            "\n3.Atiquizaya " +
                            "\n4.Concepción de Ataco " +
                            "\n5.El Refugio");
                        opc3 = int.Parse(ReadLine());
                        if (opc3 == 1)
                        {
                            departamento = "Ahuachapan";
                            municipio = "Ahuachapan";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 2)
                        {
                            departamento = "Ahuachapan";
                            municipio = "Apaneca";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "Ahuachapan";
                            municipio = "Atiquizaya";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }   
                        if (opc3 == 4)
                        {
                            departamento = "Ahuachapan";
                            municipio = "Concepcion de Ataco";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "Ahuachapan";
                            municipio = "El refugio";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                    }
                    if (opc2 == 3)
                    {
                        
                        int opc3;
                        Clear();
                        WriteLine("Municipios de Sonsonate");
                        WriteLine("\n1.Acajutla " +
                            "\n2.Armenia " +
                            "\n3.Caluco " +
                            "\n4.Cuisnahuat " +
                            "\n5.Izalco");
                        opc3 = int.Parse(ReadLine());
                        if (opc3 == 1)
                        {
                            departamento = "Sonsonate";
                            municipio = "Acajutla";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 2)
                        {
                            departamento = "Sonsonate";
                            municipio = "Armenia";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "Sonsonate";
                            municipio = "Caluco";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "Sonsonate";
                            municipio = "Cuisnahuat";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "Sonsonate";
                            municipio = "Izalco";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                    }
                    if (opc2 == 4)
                    {
                        int opc3;
                        Clear();
                        WriteLine("Municipios de San Salvador");
                        WriteLine("\n1.Guazapa" +
                            "\n2.Apopa" +
                            "\n3.Aguilares " +
                            "\n4.Ciudad Delgado " +
                            "\n5.Santa Tecla ");
                        opc3 = int.Parse(ReadLine());
                        if (opc3 == 1)
                        {
                            departamento = "San Salvador";
                            municipio = "Guazapa";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 2)
                        {
                            departamento = "San Salvador";
                            municipio = "Apopa";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "San Salvador";
                            municipio = "Aguilares";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "San Salvador";
                            municipio = "Ciudad Delgado";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "San Salvador";
                            municipio = "Santa Tecla";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                    }
                    if (opc2 == 5)
                    {

                        int opc3;
                        Clear();
                        WriteLine("Municipios de La Libertad");
                        WriteLine("\n1.Antiguo " +
                            "\n2.Cuscatlán " +
                            "\n3.Chiltiupán " +
                            "\n4.Ciudad Arce " +
                            "\n5.Colón Comasagua");
                        opc3 = int.Parse(ReadLine());
                        if (opc3 == 1)
                        {
                            departamento = "La Libertad";
                            municipio = "Antiguo";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 2)
                        {
                            departamento = "La Libertad";
                            municipio = "Cuscatlan";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "La Libertad";
                            municipio = "Chiltuapan";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "La Libertad";
                            municipio = "Ciudad Arce";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "La Libertad";
                            municipio = "Colon Comasagua";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro \t2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            else
                            {
                                WriteLine("Tus datos son: " + nombre + " " + apellido + " " + edad + " " + departamento + " " + municipio);
                            }
                        }
                    }
                    break;
                    
                }
                
                
                
            }
            else
            {
                Environment.Exit(0);
            }

        } while (opc <= 2) ;

    }
}