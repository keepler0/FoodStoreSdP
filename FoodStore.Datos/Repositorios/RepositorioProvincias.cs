using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.ComponentModel;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioProvincias : IRepositorioProvincias
	{
		public RepositorioProvincias()
		{
		}
		public void Agregar(Provincia p, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Provincias(NombreProvincia,PaisId) 
									   VALUES(@NombreProvincia,@PaisId);
									   SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, p, tran);
			p.ProvinciaId = id != 0 ? id :
			throw new Exception("Error en BD, No ha sido posible agregar el registro");
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM Provincias WHERE ProvinciaId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id },tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(Provincia p, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE Provincias SET NombreProvincia=@NombreProvincia,PaisId=@PaisId
									   WHERE ProvinciaId=@ProvinciaId";
			int rows = conexion.Execute(UpdateQuery, p,tran);
			if (rows == 0) throw new Exception(@"Error en BD, 
												 No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = "SELECT COUNT(*) FROM Localidades WHERE ProvinciaId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Provincia p, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Provincias 
										WHERE NombreProvincia=@NombreProvincia 
										AND PaisId=@PaisId";
			if (p.PaisId != 0)
			{
				SelectQuery += " AND ProvinciaId<>@ProvinciaId";
			}
			return conexion.QuerySingle<int>(SelectQuery, p) > 0;
		}

		public Provincia? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT ProvinciaId,NombreProvincia,PaisId FROM Provincias 
										WHERE ProvinciaId=@id";
			return (Provincia?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<ProvinciaListDto> GetLista(SqlConnection conexion, 
											   SqlTransaction? tran = null,
											   Ordenar? ordenar = Ordenar.Ninguno,
											   Pais? pais = null)
		{
			string SelectQuery = @"SELECT pr.ProvinciaId,pr.NombreProvincia,p.NombrePais
								    FROM Provincias pr
									INNER JOIN Paises p ON pr.PaisId=p.PaisId";
			if (pais is not null)
			{
				SelectQuery += " WHERE pr.PaisId=@PaisId";
			}
			if (ordenar is not null)
			{
				switch (ordenar)
				{
					case Ordenar.Ninguno:
						SelectQuery += " ORDER BY p.NombrePais,pr.NombreProvincia";
						break;
					case Ordenar.PaisAZ:
						SelectQuery += " ORDER BY p.NombrePais";
						break;
					case Ordenar.PaisZA:
						SelectQuery += " ORDER BY p.NombrePais DESC";
						break;
					case Ordenar.ProvinciaAZ:
						SelectQuery += " ORDER BY pr.NombreProvincia";
						break;
					case Ordenar.ProvinciaZA:
						SelectQuery += " ORDER BY pr.NombreProvincia DESC";
						break;
				}
			}
			var lista= pais is null?conexion.Query<ProvinciaListDto>(SelectQuery).ToList():
									conexion.Query<ProvinciaListDto>(SelectQuery,new {pais.PaisId}).ToList();
			return lista;
		}

		public List<Provincia> GetListaPorPais(SqlConnection conexion, int PaisId)
		{
			string SelectQuery = @"SELECT ProvinciaId,NombreProvincia,PaisId 
								   FROM Provincias
								   WHERE PaisId=@PaisId
								   ORDER BY NombreProvincia";
			return conexion.Query<Provincia>(SelectQuery, new { PaisId }).ToList();
		}
	}
}
