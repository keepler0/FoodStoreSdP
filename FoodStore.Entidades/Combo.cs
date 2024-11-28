namespace FoodStore.Entidades
{
	public class Combo
	{
		private int _comboId;
		private string _nombreCombo = null!;
		private DateTime _fechaInicio;
		private DateTime? _fechaFin;
		private string? _descripcion;
		private decimal _precioCombo;
		private int _tamanioId;
		private Tamanio? _tamanio;
		private string? _imagen;
		private List<ComboProducto> detalles=new List<ComboProducto>();

		public List<ComboProducto> Detalles
		{
			get { return detalles; }
			set { detalles = value; }
		}


		public Tamanio? Tamanio
		{
			get { return _tamanio; }
			set { _tamanio = value; }
		}
		public string? Imagen
		{
			get { return _imagen; }
			set { _imagen = value; }
		}
		public int TamanioId
		{
			get { return _tamanioId; }
			set { _tamanioId = value; }
		}
		public decimal PrecioCombo
		{
			get { return _precioCombo; }
			set { _precioCombo = value<0?value:
								throw new Exception("El valor debe ser mayor a cero"); }
		}
		public string? Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}

		public DateTime? FechaFin
		{
			get { return _fechaFin; }
			set { _fechaFin = value; }
		}
		public DateTime FechaInicio
		{
			get { return _fechaInicio; }
			set { _fechaInicio = value; }
		}
		public string NombreCombo
		{
			get { return _nombreCombo; }
			set { _nombreCombo = value; }
		}
		public int ComboId
		{
			get { return _comboId; }
			set { _comboId = value; }
		}
		public void Agregar(ComboProducto cp)
		{
			var productoEnCombo = Detalles.FirstOrDefault(d => d.ProductoId == cp.ProductoId);
			if (productoEnCombo is null)
			{
				Detalles.Add(cp);
			}
			else
			{
				cp.Cantidad += cp.Cantidad;
			}
		}
		public bool Existe(ComboProducto cp)
		{
			return Detalles.Any(d => d.ProductoId == cp.ProductoId);
		}
		public void Eliminar(ComboProducto cp)
		{
			Detalles.Remove(cp);
		}
	}
}
