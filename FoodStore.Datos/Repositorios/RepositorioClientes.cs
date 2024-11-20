using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioClientes : IRepositorioClientes
	{
		public void Agregar(Cliente cl, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Clientes(Nombre,Apellido,Telefono,DNI,Calle1,
														Calle2,NumeroCasa)
									VALUES(@Nombre,@Apellido,@Telefono,@DNI,@Calle1,
										   @Calle2,@NumeroCasa);
									SELECT SCOPE_IDENTITY()";
			int id = conexion.QuerySingle<int>(InsertQuery, cl, tran);
			if (id == 0) throw new Exception("No ha sido posible agregar el registro");
			cl.ClienteId = id;
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM Clientes WHERE ClienteId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("No ha sido posible agregar el registro");
		}

		public void Editar(Cliente cl, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE Clientes SET Nombre=@Nombre,Apellido=@Apellido,
									Telefono=@Telefono,DNI=@DNI,Calle1=@Calle1,Calle2=@Calle2,
									NumeroCasa=@NumeroCasa
									WHERE ClienteId=@ClienteId";
			int rows = conexion.Execute(UpdateQuery, cl, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Ordenes 
								   WHERE ClienteId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Cliente cl, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Clientes 
								   WHERE DNI=@DNI";
			if (cl.ClienteId != 0)
			{
				SelectQuery += " AND ClienteId<>@ClienteId";
			}
			return conexion.QuerySingle<int>(SelectQuery, cl) > 0;
		}

		public Cliente? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT ClienteId,Nombre,Apellido,Telefono,DNI,Calle1,Calle2,NumeroCasa
										FROM Clientes 
										WHERE ClienteId=@id";
			return conexion.QuerySingle<Cliente?>(SelectQuery, new { id });
		}

		public List<ClienteListDto> GetLista(SqlConnection conexion, 
											 SqlTransaction? tran = null,
											 string? nombre = null,
											 string? direccion = null,
											 OrdenarClientes? orden = OrdenarClientes.Ninguno)
		{
			string SelectQuery = @"SELECT ClienteId,NombreCompleto,DireccionCompleta
								   FROM ( SELECT ClienteId,
								   CONCAT(Nombre, ' ', Apellido) AS NombreCompleto,
								   CONCAT(Calle1, ' ', Calle2, ' ', NumeroCasa) AS DireccionCompleta
								   FROM Clientes) AS SubConsulta";
			//string SelectQuery = @"SELECT ClienteId, CONCAT(Nombre,' ',Apellido)  
			//							  AS NombreCompleto,
			//							  CONCAT(Calle1,' ',Calle2,' ',NumeroCasa) 
			//							  AS DireccionCompleta
			//					  FROM Clientes";
			if (!string.IsNullOrEmpty(nombre) &&
				!string.IsNullOrEmpty(direccion))
			{
				SelectQuery += @$" WHERE NombreCompleto LIKE '%{nombre}%' 
								   AND DireccionCompleta LIKE '%{direccion}%'";
			}
			else if (!string.IsNullOrEmpty(nombre) && 
					 !string.IsNullOrEmpty(direccion))
			{
				SelectQuery += @$" NombreCompleto LIKE '%{nombre}%' 
								   AND DireccionCompleta LIKE '%{direccion}%'";
			}
			else if (!string.IsNullOrEmpty(nombre))
			{
				SelectQuery += @$" WHERE NombreCompleto LIKE '%{nombre}%'";
			}
			else if (!string.IsNullOrEmpty(direccion))
			{
				SelectQuery += @$" WHERE DireccionCompleta LIKE '%{direccion}%'";
			}
			switch (orden)
			{
				case OrdenarClientes.Ninguno:
					break;
				case OrdenarClientes.NombreCompletoAZ:
					SelectQuery += " ORDER BY NombreCompleto";
					break;
				case OrdenarClientes.NombreCompletoZA:
					SelectQuery += " ORDER BY NombreCompleto DESC";
					break;
				case OrdenarClientes.DireccionAZ:
					SelectQuery += " ORDER BY DireccionCompleta";
					break;
				case OrdenarClientes.DireccionZA:
					SelectQuery += " ORDER BY DireccionCompleta DESC";
					break;
			}
			return conexion.Query<ClienteListDto>(SelectQuery).ToList();
		}
	}
}
