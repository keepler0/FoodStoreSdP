using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioSubCategorias : IRepositorioSubCategorias
	{
		public void Agregar(SubCategoria sc, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO SubCategorias(NombreSubCategoria,CategoriaId) 
								 VALUES(@NombreSubCategoria,@CategoriaId);
								 SELECT SCOPE_IDENTITY()";
			int id = conexion.QuerySingle<int>(InsertQuery, sc, tran);
			if (id == 0) throw new Exception("Error no fue posible agregar el registro");
			sc.SubCategoriaId = id;
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM SubCategorias WHERE SubCategoriaId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(SubCategoria sc, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE SubCategorias SET NombreSubCategoria=@NombreSubCategoria
								   WHERE SubCategoriaId=@SubCategoriaId";
			int rows = conexion.Execute(UpdateQuery, sc, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = "SELECT COUNT(*) FROM Inventario WHERE SubCategoriaId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(SubCategoria sc, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM SubCategorias 
								   WHERE NombreSubCategoria=@NombreSubCategoria 
								   AND CategoriaId=@CategoriaId";
			if (sc.CategoriaId != 0)
			{
				SelectQuery += " AND SubCategoriaId!=@SubCategoriaId";
			}
			return conexion.QuerySingle<int>(SelectQuery, sc) > 0;
		}

		public SubCategoria? GetItem(int id,
									 SqlConnection conexion,
									 SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT SubCategoriaId,NombreSubCategoria 
								   FROM SubCategorias 
								   WHERE SubCategoriaId=@id";
			return (SubCategoria?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<SubCategoriaListDto> GetLista(SqlConnection conexion,
												  SqlTransaction? tran = null,
												  OrdenarCategorias? ordenar = OrdenarCategorias.Ninguno,
												  Categoria? c = null)
		{
			string SelectQuery = @"SELECT sc.SubCategoriaId,
										  sc.NombreSubCategoria,
										   c.NombreCategoria 
									FROM SubCategorias sc
									INNER JOIN Categorias c 
									ON sc.CategoriaId=c.CategoriaId";
			if (c is not null) SelectQuery += " WHERE sc.CategoriaId=@CategoriaId";
			if (ordenar is not null)
			{
				switch (ordenar)
				{
					case OrdenarCategorias.Ninguno:
						SelectQuery += " ORDER BY c.NombreCategoria,sc.NombreSubCategoria";
						break;
					case OrdenarCategorias.CategoriaAZ:
						SelectQuery += " ORDER BY c.NombreCategoria";
						break;
					case OrdenarCategorias.CategoriaZA:
						SelectQuery += " ORDER BY c.NombreCategoria DESC";
						break;
					case OrdenarCategorias.SubCategoriaAZ:
						SelectQuery += " ORDER BY sc.NombreSubCategoria";
						break;
					case OrdenarCategorias.SubCategoriaZA:
						SelectQuery += " ORDER BY sc.NombreSubCategoria DESC";
						break;
				}
			}
			if (c is not null)
			{
				return conexion.Query<SubCategoriaListDto>(SelectQuery, c).ToList();
			}
			return conexion.Query<SubCategoriaListDto>(SelectQuery).ToList();
		}

		public List<SubCategoria> GetListaPorCategoria(SqlConnection conexion, int id)
		{
			string selectQuery = @"SELECT SubCategoriaId,NombreSubCategoria,CategoriaId
								   FROM SubCategorias
								   WHERE CategoriaId=@id";

			return conexion.Query<SubCategoria>(selectQuery, new { id }).ToList();
		}
	}
}
