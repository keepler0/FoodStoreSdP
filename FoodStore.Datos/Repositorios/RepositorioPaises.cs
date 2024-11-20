using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
    public class RepositorioPaises : IRepositorioPaises
	{
		public RepositorioPaises()
		{
		}
		public void Agregar(Pais p, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Paises(NombrePais) VALUES(@NombrePais);
								   SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, p, tran);
			p.PaisId = id != 0 ? id : throw new Exception("Error en BD, No ha sido posible agregar el registro");

		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction? tran)
		{
			string DeleteQuery = "DELETE FROM Paises WHERE PaisId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(Pais p, SqlConnection conexion, SqlTransaction? tran)
		{
			string UpdateQuery = @"UPDATE Paises SET NombrePais=@NombrePais
									   WHERE PaisId=@PaisId";
			int rows = conexion.Execute(UpdateQuery, p, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = "SELECT COUNT(*) FROM Provincias WHERE PaisId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Pais p, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Paises 
										WHERE NombrePais=@NombrePais";
			if (p.PaisId != 0)
			{
				SelectQuery += " AND PaisId<>@PaisId";
			}
			return conexion.QuerySingle<int>(SelectQuery, p) > 0;

		}

		public Pais? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT PaisId,NombrePais FROM Paises 
										WHERE PaisId=@id";
			return (Pais?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<Pais> GetLista(SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT PaisId,NombrePais
									   FROM Paises
									   ORDER BY NombrePais";
			return conexion.Query<Pais>(SelectQuery).ToList();
		}
	}
}
