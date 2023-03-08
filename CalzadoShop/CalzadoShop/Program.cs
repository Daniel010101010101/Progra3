using System;
using System.Collections.Generic;

class Shoe
{
    public string Style { get; set; }
    public string Brand { get; set; }
    public int Size { get; set; }
    public string Gender { get; set; }
    public int Discount { get; set; }

    public Shoe(string style, string brand, int size, string gender, int discount)
    {
        Style = style;
        Brand = brand;
        Size = size;
        Gender = gender;
        Discount = discount;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Estilo: {0}\nMarca: {1}\nTalla: {2}\nGénero: {3}\nDescuento: {4}%\n", Style, Brand, Size, Gender, Discount);
    }
}

class ShoeCatalog
{
    public string StoreName { get; set; }
    public List<Shoe> Shoes { get; set; }

    public ShoeCatalog(string storeName, List<Shoe> shoes)
    {
        StoreName = storeName;
        Shoes = shoes;
    }
}

class Store
{
    public string StoreName { get; set; }
    public List<ShoeCatalog> ShoeCatalogs { get; set; }
    public Store(string storeName, List<ShoeCatalog> shoeCatalogs)
    {
        StoreName = storeName;
        ShoeCatalogs = shoeCatalogs;
    }

}
class Program
{
    static void DisplayShoeCatalog(ShoeCatalog catalog)
    {
        Console.WriteLine("Catálogo de zapatos para la tienda {0}:\n", catalog.StoreName);
        foreach (Shoe shoe in catalog.Shoes)
        {
            shoe.DisplayDetails();
        }
    }

    static void Main(string[] args)
    {
        // Crear algunos zapatos
        Shoe shoe1 = new Shoe("Deportivo", "Nike", 9, "Hombre", 20);
        Shoe shoe2 = new Shoe("Formal", "Clarks", 8, "Mujer", 15);
        Shoe shoe3 = new Shoe("Casual", "Adidas", 10, "Hombre", 10);
        Shoe shoe4 = new Shoe("Deportivo", "Puma", 8, "Mujer", 5);

        // Crear algunos catálogos de zapatos
        ShoeCatalog catalog1 = new ShoeCatalog("Nike", new List<Shoe> { shoe1, shoe2 });
        ShoeCatalog catalog2 = new ShoeCatalog("Adidas", new List<Shoe> { shoe3, shoe4 });

        // Crear algunas tiendas de calzado
        Store store1 = new Store("Nike", new List<ShoeCatalog> { catalog1 });
        Store store2 = new Store("Adidas", new List<ShoeCatalog> { catalog2 });

        // Crear una lista de tiendas
        List<Store> stores = new List<Store> { store1, store2 };

        // Mostrar las tiendas disponibles
        Console.WriteLine("Tiendas de calzado disponibles:\n");
        foreach (Store store in stores)
        {
            Console.WriteLine(store.StoreName);
        }

        // Pedir al usuario que seleccione una tienda
        Console.WriteLine("\nSelecciona una tienda (introduce el nombre):");
        string selectedStoreName = Console.ReadLine();

        // Buscar la tienda seleccionada
        Store selectedStore = null;
        foreach (Store store in stores)
        {
            if (store.StoreName == selectedStoreName)
            {
                selectedStore = store;
                break;
            }
        }

        // Mostrar el catálogo de zapatos de la tienda seleccionada
        if (selectedStore != null)
        {
            foreach (ShoeCatalog catalog in selectedStore.ShoeCatalogs)
            {
                DisplayShoeCatalog(catalog);
            }
        }
        else
        {
            Console.WriteLine("\nTienda no encontrada.");
        }

        Console.ReadLine();
    }
}
