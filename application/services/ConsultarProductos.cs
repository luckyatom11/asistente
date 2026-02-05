using mercaditoutm.application.core.entities;
using mercaditoutm.application.core.use_case;
using System.Collections.Generic;

namespace mercaditoutm.application.services
{
    public class ConsultarProductos : IConsultarProductos
    {
        public List<Articulo> Ejecutar()
        {
            var articulos = new List<Articulo>();
            var random = new Random();
            var nombres = new[] { "Laptop", "Mouse", "Teclado", "Monitor", "Webcam", "Micrófono", "Silla Gamer", "Escritorio" };
            var marcas = new[] { "BrandA", "BrandB", "BrandC", "TechCorp", "GameMax", "OfficePro" };

            for (int i = 0; i < 25; i++)
            {
                articulos.Add(new Articulo
                {
                    Nombre = $"{nombres[random.Next(nombres.Length)]} #{i + 1}",
                    Precio = (decimal)(random.NextDouble() * 1000 + 50),
                    Sku = $"SKU-{random.Next(10000, 99999)}",
                    Stock = random.Next(0, 100),
                    Marca = marcas[random.Next(marcas.Length)]
                });
            }
            return articulos;
        }
    }
}
