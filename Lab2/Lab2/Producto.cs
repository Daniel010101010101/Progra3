using System;

namespace Lab2
{
    public class Producto
    {
        public string nombre;
        public string proveedor;
        public string fechaCaducidad;
        public string detalles;
        DateTime hora = DateTime.Now;
        public float precio;
        public int cantidad;
        

        public Producto(string nombre,string proveedor,string fechaCaducidad,string detalles,DateTime hora, float precio, int cantidad) 
        {
            this.nombre = nombre;
            this.proveedor = proveedor;
            this.fechaCaducidad = fechaCaducidad;
            this.detalles = detalles;
            this.hora = hora;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public float Venta()
        {
            return precio * cantidad;
        }
    }
}