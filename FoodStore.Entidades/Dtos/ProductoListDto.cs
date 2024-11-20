using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Entidades.Dtos
{
    public class ProductoListDto
    {
        public int ProductoId { get; set; }
        public string? Marca { get; set; }
        public string? Descripcion { get; set; }
        public int Stock { get; set; }
        public string? NombreCategoria { get; set; }
        public string? NombreSubCategoria { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioFinal { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public static implicit operator ProductoListDto(Producto p)
        {
            return new ProductoListDto
            {
                ProductoId = p.ProductoId,
                Marca = p.Marca,
                Descripcion = p.Descripcion,
                Stock = p.Stock,
                NombreCategoria = p.Categoria?.NombreCategoria ?? "N/D",
                NombreSubCategoria = p.SubCategoria?.NombreSubCategoria ?? "N/D",
                PrecioFinal = p.PrecioFinal,
                PrecioUnitario = p.PrecioUnitario,
                FechaVencimiento = p.FechaVencimiento
            };
        }
    }
}
