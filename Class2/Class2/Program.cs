using System;
using System.Collections.Generic;

class Producto {
    public string nombre;
    public float precio;
    public int cantidad;

    public Producto(string nombre, float precio, int cantidad) {
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad = cantidad;
    }
}

class Program {
    static void Main(string[] args) {
        List<Producto> listaProductos = new List<Producto>();

        while (true) {
            Console.Write("Ingresa el nombre del producto (o escribe 'salir' para terminar): ");
            string nombre = Console.ReadLine();

            if (nombre == "salir") {
                break;
            }

            Console.Write("Ingresa el precio del producto: ");
            float precio = float.Parse(Console.ReadLine());

            Console.Write("Ingresa la cantidad del producto: ");
            int cantidad = int.Parse(Console.ReadLine());

            Producto nuevoProducto = new Producto(nombre, precio, cantidad);
            listaProductos.Add(nuevoProducto);

            Console.WriteLine("Producto agregado a la lista.");
        }

        Console.WriteLine("\nLa lista de productos es:");

        foreach (Producto producto in listaProductos) {
            Console.WriteLine("Nombre: {0}, Precio: {1}, Cantidad: {2}", producto.nombre, producto.precio, producto.cantidad);
        }
    }
}