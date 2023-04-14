using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab2
{
    class AgregarProducto
    {
        private Areas areas = new Areas();
        private DateTime hora = DateTime.Now;
        public void Agregar() 
        {
            List<Producto> lista = new List<Producto>();
            int totalCompras = 0;
            while (true)
            {
                WriteLine("Ingresa el nombre del producto  (Escribe 'Venta' para realizar proceso de venta" +
                          " o escribe  'salir' para terminar): ");
                string nombre = ReadLine();
                if (nombre=="salir")
                {
                    break;
                }

                if (nombre=="venta")
                {
                    while (true)
                    {
                        WriteLine("\n¿Cuál producto quieres comprar? Ingresa el nombre (o escribe 'Salir' para terminar): ");
                        string productoComprar = ReadLine();
                        if (productoComprar =="salir")
                        {
                            break;
                        }

                        WriteLine("¿Cuántas unidades quieres comprar? Ingresa la cantidad: ");
                        int cantidadComprar = int.Parse(ReadLine());

                        Producto productoSeleccionado = lista.Find(producto => producto.nombre == productoComprar);

                        if (productoSeleccionado == null) {
                            WriteLine("El producto no existe en la lista.");
                        } else if (productoSeleccionado.cantidad < cantidadComprar) {
                            WriteLine("No hay suficientes unidades del producto en la lista.");
                        } else {
                            float precioTotal = productoSeleccionado.precio * cantidadComprar;
                            productoSeleccionado.cantidad -= cantidadComprar;
                            totalCompras++;
                            WriteLine("Compra realizada con éxito. Total a pagar: {0}", precioTotal);
                        }
                        WriteLine("\nEl total de compras realizadas es: {0}",totalCompras);
                        
                    }
                }
             
                WriteLine("Ingresa el proveedor del producto: ");
                string proveedor = ReadLine();
                WriteLine("Ingresa la fecha de caducidad del producto: ");
                string fechaCaducidad = ReadLine();
                WriteLine("Ingresa los detalles del producto: ");
                string detalles = ReadLine();
                WriteLine("Ingresa el precio del producto: ");
                float precio = float.Parse(ReadLine());
                WriteLine("Ingresa la cantidad del producto: ");
                int  cantidad = int.Parse(ReadLine());
                WriteLine("\nLa fecha de entrada es: " + hora.ToString("f"));
                Producto nuevoProducto = new Producto(nombre, proveedor, fechaCaducidad, detalles, hora, precio, cantidad);
                lista.Add(nuevoProducto);
                WriteLine("\nProducto agregado al inventario.");
            }
            WriteLine("\nEl inventario es:");
            foreach (Producto producto in lista)
            {
                WriteLine("Nombre: {0} " +
                          "Proveedor: {1} " +
                          "Fecha de caducidad: {2} " +
                          "Detalles: {3} " +
                          "Precio: {4} " +
                          "Cantidad: {5} ",producto.nombre,producto.proveedor,producto.fechaCaducidad,
                    producto.detalles,producto.precio,producto.cantidad);
                
            }
        }
    }
}
