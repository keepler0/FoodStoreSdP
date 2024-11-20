using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosRoles : IServiciosRoles
	{
		private readonly IRepositorioRoles _repositorio;
		private string cadenaConexion=string.Empty;
        public ServiciosRoles(IRepositorioRoles repositorio,string cadena)
        {
            _repositorio=repositorio;
			cadenaConexion= cadena;
        }
        public List<Rol> GetLista()
		{
			try
			{
				using (var conexion=new SqlConnection(cadenaConexion))
				{
					conexion.Open();
					return _repositorio.GetLista(conexion);
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
