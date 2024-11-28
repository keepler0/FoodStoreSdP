using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioTamanios : IRepositorioTamanios
	{
		public RepositorioTamanios()
		{
		}
		public void Agregar(Tamanio p,SqlConnection conexion,SqlTransaction tran)
		{

			string InsertQuery = @"INSERT INTO Tamanios(NombreTamanio) 
									   VALUES(@Nombre);
									   SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, p);
			p.TamanioId = id != 0 ? id : throw new Exception("Error en BD, No ha sido posible agregar el registro");
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM Tamanios WHERE TamanioId=@TamanioId";
			int rows = conexion.Execute(DeleteQuery, new { id });
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(Tamanio p, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE Tamanios SET NombreTamanio=@NombreTamanio
									   WHERE TamanioId=@TamanioId";
			int rows = conexion.Execute(UpdateQuery, p);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran=null)
		{
			string SelectQuery = "SELECT COUNT(*) FROM Combos WHERE TamanioId=@TamanioId";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Tamanio p, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Tamanios 
										WHERE NombreTamanio=@NombreTamanio";
			if (p.TamanioId != 0)
			{
				SelectQuery += " AND TamanioId<>@TamanioId";
			}
			return conexion.QuerySingle<int>(SelectQuery, p) > 0;
		}

		public Tamanio? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT TamanioId,NombreTamanio FROM Tamanios 
										WHERE TamanioId=@TamanioId";
			return (Tamanio?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<Tamanio> GetLista(SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT TamanioId,NombreTamanio 
									   FROM Tamanios
									   ORDER BY NombreTamanio";
			return conexion.Query<Tamanio>(SelectQuery).ToList();
		}
	}
}
