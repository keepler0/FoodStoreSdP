using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioGenerico<T> where T : class
	{
		void Agregar(T item,SqlConnection conexion,SqlTransaction tran);
		void Editar(T item, SqlConnection conexion, SqlTransaction tran);
		void Borrar(int id, SqlConnection conexion, SqlTransaction tran);
		List<T> GetLista(SqlConnection conexion, SqlTransaction? tran = null);
		bool Existe(T item, SqlConnection conexion, SqlTransaction? tran=null);
		bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
		T? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
	}
}
