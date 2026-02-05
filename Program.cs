using System;
using System.Collections.Generic;
using mercaditoutm.application.core.entities;
using mercaditoutm.application.core.use_case;
using mercaditoutm.application.services;



Console.WriteLine("Lista de Artículos Generados:");
Console.WriteLine("".PadRight(80, '-'));

IAgregarProducto agregarProducto = new AgregarProducto();
Articulo nuevoArticulo = new Articulo
{
    Nombre = "Nuevo Producto de Prueba",
    Precio = 99.99m,
    Sku = "SKU-TEST-001",
    Stock = 10,
    Marca = "Marca Prueba"
};

Console.WriteLine("\nAgregando un nuevo producto:");
agregarProducto.Ejecutar(nuevoArticulo);

Console.WriteLine("".PadRight(80, '-'));


IConsultarProductos consultarProductos = new ConsultarProductos();
List<Articulo> articulos = consultarProductos.Ejecutar();

foreach (var articulo in articulos)
{
    Console.WriteLine($"Nombre: {articulo.Nombre,-20} | Precio: {articulo.Precio,-10:C} | SKU: {articulo.Sku,-12} | Stock: {articulo.Stock,-5} | Marca: {articulo.Marca,-10}");
}

Console.WriteLine("".PadRight(80, '-'));
