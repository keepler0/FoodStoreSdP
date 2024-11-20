using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioTiposDeOrden : IRepositorioGenerico<TipoOrden>
	{
        public RepositorioTiposDeOrden()
        {
        }
        public void Agregar(TipoOrden item, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO TiposDeOrden(Nombre) VALUES(@Nombre);
									   SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, item);
			item.TipoOrdenId = id != 0 ? id : throw new Exception("Error en BD, No ha sido posible agregar el registro");
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM TiposDeOrden WHERE TipoOrdenId=@TipoOrdenId";
			int rows = conexion.Execute(DeleteQuery, new { id });
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(TipoOrden item, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE TiposDeOrden SET Nombre=@Nombre
									   WHERE TipoOrdenId=@TipoOrdenId";
			int rows = conexion.Execute(UpdateQuery, item);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran=null)
		{
			string SelectQuery = "SELECT COUNT(*) FROM Ordenes WHERE TipoOrenId=@TipoOrenId";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;

		}

		public bool Existe(TipoOrden item, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM TiposDeOrden 
										WHERE Nombre=@Nombre";
			if (item.TipoOrdenId != 0)
			{
				SelectQuery += " AND TipoOrdenId<>@TipoOrdenId";
			}
			return conexion.QuerySingle<int>(SelectQuery, item) > 0;
		}

		public TipoOrden? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT TipoOrdenId,Nombre FROM TiposDeOrden 
										WHERE TipoOrdenId=@TipoOrdenId";
			return (TipoOrden?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<TipoOrden> GetLista(SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT TipoOrdenId,Nombre 
									   FROM TiposDeOrden
									   ORDER BY Nombre";
			return conexion.Query<TipoOrden>(SelectQuery).ToList();
		}
	}
}
