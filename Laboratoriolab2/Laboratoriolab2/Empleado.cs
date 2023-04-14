using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Empleado
    {
        string usuario;
        private string admin;
        int cat1;
        int area1;
        int id;
        string nombre;
        int edad;
        int nivel1;
        int nivel2;
        string nombreCliente;
        string password;
        string email;
       

        public string Usuario { get => usuario; set => usuario = value; }
        public string Admin { get => admin; set => admin = value; }
        public int Cat1 { get => cat1; set => cat1 = value; }
        public int Area1 { get => area1; set => area1 = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Nivel1 { get => nivel1; set => nivel1 = value; }
        public int Nivel2 { get => nivel2; set => nivel2 = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}