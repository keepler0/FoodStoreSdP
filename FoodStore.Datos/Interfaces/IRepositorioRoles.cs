using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioRoles
	{
		List<Rol> GetLista(SqlConnection conexion);
	}
}
