namespace FoodStore.Entidades
{
	public class Empleado
	{
		private int _empleadoId;
		private string _nombre = null!;
		private string _apellido = null!;
		private string _direccion = null!;
		private string _telefono = null!;
		private string _cuit = null!;
		private int _rolId;
		private Rol? _rol;
		private decimal _sueldo;
		private DateTime _fechaContrato;
		private bool _activo;
		private string? _foto;

		public string? Foto
		{
			get { return _foto; }
			set { _foto = value; }
		}
		public Rol? Rol
		{
			get { return _rol; }
			set { _rol = value; }
		}
		public bool Activo
		{
			get { return _activo; }
			set { _activo = value; }
		}
		public DateTime FechaContrato
		{
			get { return _fechaContrato; }
			set { _fechaContrato = value; }
		}
		public decimal Sueldo
		{
			get { return _sueldo; }
			set { _sueldo = value; }
		}
		public int RolId
		{
			get { return _rolId; }
			set { _rolId = value; }
		}
		public string Cuit
		{
			get { return _cuit; }
			set { _cuit = value; }
		}
		public string Telefono

		{
			get { return _telefono; }
			set { _telefono = value; }
		}
		public string Direccion
		{
			get { return _direccion; }
			set { _direccion = value; }
		}
		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}
		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		public int EmpleadoId
		{
			get { return _empleadoId; }
			set { _empleadoId = value; }
		}
	}
}
