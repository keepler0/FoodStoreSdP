using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioEmpleados : IRepositorioEmpleados
	{
		public void Agregar(Empleado e, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Empleados(Nombre,Apellido,Direccion,
													   Telefono,Cuit,RolId,
													   Sueldo,FechaContrato,Activo,Foto)
									VALUES(@Nombre,@Apellido,@Direccion,@Telefono,
											@Cuit,@RolId,@Sueldo,@FechaContrato,@Activo,@Foto);
									SELECT SCOPE_IDENTITY()";
			int id = conexion.QuerySingle<int>(InsertQuery, e, tran);
			if (id == 0) throw new Exception("No ha sido posible agregar el registro");
			e.EmpleadoId=id;
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM Empleados WHERE EmpleadoId=@id";
			int rows = conexion.ExecuteScalar<int>(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("No ha sido posible agregar el registro");

		}

		public void Editar(Empleado e, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE Empleados SET Nombre=@Nombre,Apellido=@Apellido,
									Direccion=@Direccion,Telefono=@Telefono,
									Cuit=@Cuit,RolId=@RolId,Sueldo=@Sueldo,FechaContrato=@FechaContrato,
									Activo=@Activo,Foto=@Foto
									WHERE EmpleadoId=@EmpleadoId";
			int rows = conexion.Execute(UpdateQuery, e, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Ordenes 
								   WHERE EmpleadoId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Empleado e, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Empleados 
								   WHERE Cuit=@Cuit";
			if (e.EmpleadoId != 0)
			{
				SelectQuery += " AND EmpleadoId<>@EmpleadoId";
			}
			return conexion.QuerySingle<int>(SelectQuery, e) > 0;
		}

		public Empleado? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT EmpleadoId,Nombre,Apellido,Direccion,Telefono,Cuit,RolId,
										  Sueldo,FechaContrato,Activo,Foto
										FROM Empleados 
										WHERE EmpleadoId=@id";
			return conexion.QueryFirstOrDefault<Empleado>(SelectQuery, new { id });
		}

		public List<EmpleadoListDto> GetLista(SqlConnection conexion,
											  SqlTransaction? tran = null,
											  string? filtroNombre = null,
											  string? filtroApellido = null,
											  Rol? rol = null,
					  filtroEmpleadosActivos? filtroEstado = filtroEmpleadosActivos.Ninguno,
							OrdenarEmpleados? orden = OrdenarEmpleados.Ninguno)
		{
			string SelectQuery = @"SELECT e.EmpleadoId,e.Nombre,e.Apellido,e.Cuit
										 ,r.NombreRol,e.Sueldo,e.FechaContrato,e.Activo,e.Foto
										FROM Empleados e
										INNER JOIN Roles r ON e.RolId=r.RolId";

			if (!string.IsNullOrEmpty(filtroNombre) &&
				!string.IsNullOrEmpty(filtroApellido) &&
				rol is not null &&
				filtroEstado is not null)
			{
				SelectQuery += @$" WHERE e.Nombre LIKE '%'+ @filtroNombre +'%'
								  AND e.Apellido LIKE '%'+ @filtroApellido +'%'
								  AND e.RolId={rol.RolId}";
				switch (filtroEstado)
				{
					case filtroEmpleadosActivos.Ninguno:
						break;
					case filtroEmpleadosActivos.Activo:
						SelectQuery += " AND e.Activo=1";
						break;
					case filtroEmpleadosActivos.Inactivo:
						SelectQuery += " AND e.Activo=0";
						break;
				}

			}
			else if (!string.IsNullOrEmpty(filtroNombre) &&
				!string.IsNullOrEmpty(filtroApellido) &&
				rol is not null)
			{
				SelectQuery += @$" WHERE e.Nombre LIKE '%'+ @filtroNombre +'%'
								  AND e.Apellido LIKE '%'+ @filtroApellido +'%'
								  AND e.RolId={rol.RolId}";
			}
			else if (!string.IsNullOrEmpty(filtroNombre) &&
					 !string.IsNullOrEmpty(filtroApellido))
			{
				SelectQuery += @$" WHERE e.Nombre LIKE '%'+ {filtroNombre} +'%'
								  AND e.Apellido LIKE '%'+ {filtroApellido} +'%'";
			}
			else if (!string.IsNullOrEmpty(filtroNombre))
			{
				SelectQuery += @$" WHERE e.Nombre LIKE '%'+ {filtroNombre} +'%'";
			}
			else if (!string.IsNullOrEmpty(filtroApellido))
			{
				SelectQuery += @$" WHERE e.Apellido LIKE '%'+ {filtroApellido} +'%'";
			}
			else if (rol is not null)
			{
				SelectQuery += @$" WHERE e.RolId={rol.RolId}";
			}
			else if (filtroEstado is not null)
			{
				switch (filtroEstado)
				{
					case filtroEmpleadosActivos.Ninguno:
						break;
					case filtroEmpleadosActivos.Activo:
						SelectQuery += " WHERE e.Activo=1";
						break;
					case filtroEmpleadosActivos.Inactivo:
						SelectQuery += " WHERE e.Activo=0";
						break;
				}
			}

			switch (orden)
			{
				case OrdenarEmpleados.Ninguno:
					break;
				case OrdenarEmpleados.NombreAZ:
					SelectQuery += " ORDER BY e.Nombre";
					break;
				case OrdenarEmpleados.NombreZA:
					SelectQuery += " ORDER BY e.Nombre DESC";
					break;
				case OrdenarEmpleados.ApellidoAZ:
					SelectQuery += " ORDER BY e.Apellido";
					break;
				case OrdenarEmpleados.ApellidoZA:
					SelectQuery += " ORDER BY e.Apellido DESC";
					break;
				case OrdenarEmpleados.RolAZ:
					SelectQuery += " ORDER BY r.NombreRol";
					break;
				case OrdenarEmpleados.RolZA:
					SelectQuery += " ORDER BY r.NombreRol DESC";
					break;
				case OrdenarEmpleados.Cuit:
					SelectQuery += " ORDER BY e.Cuit";
					break;
				case OrdenarEmpleados.CuitDESC:
					SelectQuery += " ORDER BY e.Cuit DESC";
					break;
			}
			return conexion.Query<EmpleadoListDto>(SelectQuery).ToList();
		}
	}
}
