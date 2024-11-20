
using System.Text.RegularExpressions;

namespace FoodStore.Entidades
{
	public class Cliente
	{
		private int _clienteId;
		private string? _nombre;
		private string? _apellido;
		private string? _telefono;
		private string? _dni;
		private string? _calle1;
		private string? _calle2;
		private string? _numeroCasa;

		public string? NumeroCasa
		{
			get { return _numeroCasa; }
			set 
			{
				if (!string.IsNullOrEmpty(value))
				{
					_numeroCasa = Regex.IsMatch(value!.Trim(), @"\d{1,4}$") ? value :
					throw new Exception("El numero de hogar no valido");
				}
			}
		}


		public string? Calle2
		{
			get { return _calle2; }
			set { _calle2 = value; }
		}


		public string? Calle1
		{
			get { return _calle1; }
			set { _calle1 = value; }
		}


		public string? DNI
		{
			get { return _dni; }
			set 
			{
				if (!string.IsNullOrEmpty(value))
				{
					if (Regex.IsMatch(value!.Trim(), @"^\d{7,8}$"))
					{
						_dni=value;
					}
					else
					{
						throw new Exception("El dni no es valido");
					}
				}
			}
		}
		public string? Telefono
		{
			get { return _telefono; }
			set 
			{
				if (!string.IsNullOrEmpty(value))
				{
					if (Regex.IsMatch(value,@"\d{10,11}"))
					{
						_telefono = value;
					}
					else
					{
						throw new Exception("Numero telefonico no valido");
					}
				}
			}
		}
		public string? Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}
		public string? Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		public int ClienteId
		{
			get { return _clienteId; }
			set { _clienteId = value; }
		}

	}
}
