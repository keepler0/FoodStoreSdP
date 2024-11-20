namespace FoodStore.Entidades
{
	public class Combo
	{
		private int _comboId;
		private string _nombre = null!;
		private DateOnly _fechaInicio;
		private DateOnly? _fechaFin;
		private string? _descripcion;
		private decimal _precioCombo;
		private int _tamanioId;
		private Tamanio? _tamanio;
		private string? _imagen;

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

		public DateOnly? FechaFin
		{
			get { return _fechaFin; }
			set { _fechaFin = value; }
		}
		public DateOnly FechaInicio
		{
			get { return _fechaInicio; }
			set { _fechaInicio = value; }
		}
		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		public int ComboId
		{
			get { return _comboId; }
			set { _comboId = value; }
		}
	}
}
