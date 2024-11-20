namespace FoodStore.Entidades
{
	public class ProductoProveedor
	{
		public int ProductoProveedorId { get; set; }
		public int ProveedorId { get; set; }
		public Proveedor Proveedor { get; set; } = null!;
		public int ProductoId { get; set; }
		public Producto Producto { get; set; } = null!;
		public DateOnly FechaCompra { get; set; }
		public int Cantidad { get; set; }
		public decimal PrecioCompra { get; set; }
		public int EstadoId { get; set; }
		public Estado Estado { get; set; } = null!;
		public DateOnly FechaVencimiento { get; set; }

	}
}
