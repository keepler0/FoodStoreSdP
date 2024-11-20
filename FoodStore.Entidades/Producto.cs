namespace FoodStore.Entidades
{
	public class Producto
	{
		public int ProductoId { get; set; }
        public string? Marca { get; set; }
        public string? Descripcion { get; set; }
		public int Stock { get; set; }
		public int StockMinimo { get; set; }
		public int CategoriaId { get; set; }
		public Categoria? Categoria { get; set; } = null!;
        public int SubCategoriaId { get; set; }
        public SubCategoria? SubCategoria { get; set; }
        public decimal PrecioUnitario { get; set; }
		public decimal PrecioFinal { get; set; }
		public DateTime? FechaVencimiento { get; set; }
        public string? CodigoBarras { get; set; }
        public string? Imagen { get; set; }
    }
}
