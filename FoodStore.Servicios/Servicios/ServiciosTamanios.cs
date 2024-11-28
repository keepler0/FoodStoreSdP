using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosTamanios : IServiciosTamanios
	{
		private readonly IRepositorioTamanios _repositorio;
		private readonly string cadenaConexion = string.Empty;
		public ServiciosTamanios(IRepositorioTamanios repositorio,string cadena)
		{
			_repositorio = repositorio;
			cadenaConexion = cadena;
		}
		public List<Tamanio> GetLista()
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetLista(conexion);
				}
				catch (Exception)
				{

					throw;
				}

			}
		}
	}
}
