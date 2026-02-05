using mercaditoutm.application.core.entities;
using mercaditoutm.application.core.use_case;
using System;

namespace mercaditoutm.application.services
{
    public class AgregarProducto : IAgregarProducto
    {
        public void Ejecutar(Articulo articulo)
        {
            // In a real application, this would involve saving the product to a database.
            // For now, we'll just print the product details to the console to confirm it's working.
            Console.WriteLine("Ejecutando caso de uso: Agregar Producto");
            Console.WriteLine($"Nombre: {articulo.Nombre}");
            Console.WriteLine($"Precio: {articulo.Precio}");
            Console.WriteLine($"SKU: {articulo.Sku}");
            Console.WriteLine($"Stock: {articulo.Stock}");
            Console.WriteLine($"Marca: {articulo.Marca}");
            Console.WriteLine("Producto agregado (simulación).");
        }
    }
}
