using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	//TODO:Cambiar en GetLista que trabaje con un objeto listDto
	public class RepositorioLocalidades : IRepositorioLocalidades
	{
		public RepositorioLocalidades()
		{
		}
		public void Agregar(Localidad p, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Localidades(NombreLocalidad,ProvinciaId) 
									   VALUES(@NombreLocalidad,@ProvinciaId);
									   SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, p, tran);
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM Localidades WHERE LocalidadId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(Localidad p, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE Localidades 
									   SET Nombre=@Nombre,ProvinciaId=@ProvinciaId
									   WHERE LocalidadId=@LocalidadId";
			int rows = conexion.Execute(UpdateQuery, p, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Empleados 
									   WHERE LocalidadId=@id";
			//TODO:Verificar el query
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Localidad p, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Localidades 
								   WHERE NombreLocalidad=@NombreLocalidad";
			if (p.LocalidadId != 0)
			{
				SelectQuery += " AND LocalidadId<>@LocalidadId";
			}
			return conexion.QuerySingle<int>(SelectQuery, p) > 0;
		}

		public Localidad? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT LocalidadId,NombreLocalidad,ProvinciaId 
										FROM Localidades 
										WHERE LocalidadId=@id";
			return (Localidad?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<LocalidadListDto> GetLista(SqlConnection conexion,
											   SqlTransaction? tran = null,
											   OrdenarLocalidades? ordenar = OrdenarLocalidades.Ninguno,
											   Pais? pais = null,
											   Provincia? provincia = null)
		{
			string SelectQuery = @"SELECT l.LocalidadId,l.NombreLocalidad ,pr.NombreProvincia,p.NombrePais
								   FROM Localidades l
								   INNER JOIN Provincias pr ON l.ProvinciaId=pr.ProvinciaId
								   INNER JOIN Paises p ON pr.PaisId=p.PaisId";
			if (pais is not null)
			{
				SelectQuery += " WHERE pr.PaisId=@PaisId";
				if (provincia is not null)
				{
					SelectQuery += " AND l.ProvinciaId=@ProvinciaId";
				}
			}
			if (ordenar is not null)
			{
				switch (ordenar)
				{
					case OrdenarLocalidades.Ninguno:
						SelectQuery += " ORDER BY p.NombrePais,pr.NombreProvincia,l.NombreLocalidad";
						break;
					case OrdenarLocalidades.PaisAZ:
						SelectQuery += " ORDER BY p.NombrePais";
						break;
					case OrdenarLocalidades.PaisZA:
						SelectQuery += " ORDER BY p.NombrePais DESC";
						break;
					case OrdenarLocalidades.ProvinciaAZ:
						SelectQuery += " ORDER BY pr.NombreProvincia";
						break;
					case OrdenarLocalidades.ProvinciaZA:
						SelectQuery += " ORDER BY pr.NombreProvincia DESC";
						break;
					case OrdenarLocalidades.LocalidadAZ:
						SelectQuery += " ORDER BY l.NombreLocalidad";
						break;
					case OrdenarLocalidades.LocalidadZA:
						SelectQuery += " ORDER BY l.NombreLocalidad DESC";
						break;
				}
			}
			var lista = new List<LocalidadListDto>();
			if (pais is not null)
			{
				lista = conexion.Query<LocalidadListDto>(SelectQuery, new { @PaisId = pais.PaisId }).ToList();
				if (provincia is not null)
				{
					lista = conexion.Query<LocalidadListDto>
						   (SelectQuery, new { @PaisId = pais.PaisId, @ProvinciaId = provincia.ProvinciaId })
							.ToList();
				}
			}
			else
			{
				lista = conexion.Query<LocalidadListDto>(SelectQuery).ToList();
			}
			return lista;
		}

		public List<Localidad> GetListaPorProvincia(SqlConnection conexion, int id)
		{
			string SelectQuery = @"SELECT LocalidadId,NombreLocalidad,ProvinciaId 
								   FROM Localidades 
								   WHERE ProvinciaId=@id";
			return conexion.Query<Localidad>(SelectQuery, new { id }).ToList();
		}
	}
}
