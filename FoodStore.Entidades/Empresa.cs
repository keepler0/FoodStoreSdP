using System.Text.RegularExpressions;

namespace FoodStore.Entidades
{
	public class Empresa : ICloneable
	{
		private int _empresaId;
		private string _razonSocial = null!;
		private string? _telefono;
		private string? _email;
		private string? _direccion;
		private string? _cuit;

		public int EmpresaId { get=>_empresaId; set { _empresaId = value; } }
		public string RazonSocial
		{
			get => _razonSocial;
			set => _razonSocial = value is null ?
								  throw new Exception("Debe asignar una razon social") :
								  value;
		}
		public string? Telefono
		{
			get => _telefono;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					string patron = @"^\d{10,11}";
					if (Verificar(value, patron))
					{
						_telefono = value;
					}
					else
					{
						throw new Exception("El numero telefonico no es valido");
					}
				};
			}
		}
		public string? Email
		{
			get => _email;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(?:\.[a-zA-Z]{2,})?$";
					if (Verificar(value, patron))
					{
						_email = value;
					}
					else
					{
						throw new Exception("El email no es valido");
					}
				}
			}
		}
		public string? Direccion
		{
			//TODO: Controlar la exepcion del array ya que al introducir un solo dato esta larga la excepcion

			get => _direccion;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					var dir = value.Split(',');
					var num = dir[2];
					var patron = @"^\d{0,4}$| ";
					if (Verificar(num, patron))
					{
						_direccion = value;
					}
					else
					{
						throw new Exception("Direccion erronea");
					}
				}
			}
		}
		public string? Cuit
		{
			get => _cuit;
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value))
					{
						var nums = new List<string>
					{"20", "23", "24", "27", "30", "33", "34", "50", "55", "70", "77", "80", "90"};
						var d = value.Split("-");
						var c1 = d[0];
						var c2 = d[1];
						var c3 = d[2];
						string patron = @"^\d{8}";
						if (Verificar(c2, patron) && nums.Any(n => n == c1) && CalcularDigitovalidador(c1 + c2) == c3)
						{
							_cuit = value;
						}
						else
						{
							throw new Exception("Cuit no valido");
						}
					};
				}
				catch (Exception)
				{
					throw new Exception("Cuit no valido");
				}
			}
		}

		private string CalcularDigitovalidador(string v)
		{
			int[] pesos = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

			int suma = 0;
			for (int i = 0; i < 10; i++)
			{
				suma += int.Parse(v[i].ToString()) * pesos[i];
			}
			int resto = suma % 11;

			if (resto == 0)
			{
				return "0";
			}
			else if (resto == 1)
			{
				return "9";
			}
			else
			{
				return $"{11 - resto}";
			}
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
		private bool Verificar(string value, string patron) => Regex.IsMatch(value, patron);
	}
}
