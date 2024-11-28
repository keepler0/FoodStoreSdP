namespace FoodStore.Entidades
{
	public class ComboProducto
	{
		private int _comboProductoId;
		private int _productoId;
		private Producto? _producto;
        public int CategoriaId { get; set; }

        public Producto? Producto
		{
			get { return _producto; }
			set { _producto = value; }
		}

		private int _comboId;
		private Combo? _combo;

		public Combo Combo
		{
			get { return _combo!; }
			set { _combo = value; }
		}

		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}
		public int ComboId
		{
			get { return _comboId; }
			set { _comboId = value; }
		}
		public int ProductoId
		{
			get { return _productoId; }
			set { _productoId = value; }
		}
		public int ComboProductoId
		{
			get { return _comboProductoId; }
			set { _comboProductoId = value; }
		}
	}
}
