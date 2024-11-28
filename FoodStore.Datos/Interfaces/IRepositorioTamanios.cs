using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioTamanios
	{
		List<Tamanio> GetLista(SqlConnection conexion, SqlTransaction? tran = null);
	}
}
