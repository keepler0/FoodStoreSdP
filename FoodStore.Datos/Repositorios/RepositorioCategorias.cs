using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioCategorias : IRepositorioCategorias
	{
        public RepositorioCategorias()
        {
            
        }

		public void Agregar(Categoria c, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Categorias(NombreCategoria) 
								   VALUES(@NombreCategoria);
								   SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, c, tran);
			c.CategoriaId = id != 0 ? id : throw new Exception("Error en BD, No ha sido posible agregar el registro");
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM Categorias WHERE CategoriaId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = "SELECT COUNT(*) FROM Inventario WHERE CategoriaId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Categoria c, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Categorias 
								   WHERE NombreCategoria=@NombreCategoria";
			if (c.CategoriaId != 0)
			{
				SelectQuery += " AND CategoriaId<>@CategoriaId";
			}
			return conexion.QuerySingle<int>(SelectQuery, c) > 0;
		}

		public Categoria? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT CategoriaId,NombreCategoria 
								   FROM Categorias 
									WHERE CategoriaId=@id";
			return (Categoria?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<Categoria> GetLista(SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT CategoriaId,NombreCategoria 
									FROM Categorias
									ORDER BY NombreCategoria";
			return conexion.Query<Categoria>(SelectQuery).ToList();
		}

		public void Editar(Categoria categoria, SqlConnection conexion, SqlTransaction? tran)
		{
			string UpdateQuery = @"UPDATE Categorias SET NombreCategoria=@NombreCategoria
								   WHERE CategoriaId=@CategoriaId";
			int rows = conexion.Execute(UpdateQuery, categoria, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}
	}
}
