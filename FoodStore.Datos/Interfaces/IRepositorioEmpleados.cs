using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioEmpleados
	{
		void Borrar(int id, SqlConnection conexion, SqlTransaction tran);
		bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
		bool Existe(Empleado e, SqlConnection conexion, SqlTransaction? tran = null);
		Empleado? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
		List<EmpleadoListDto> GetLista(SqlConnection conexion, SqlTransaction? tran = null,
									   string? filtroNombre = null,
									   string? filtroApellido = null,
									   Rol? rol = null,
									   filtroEmpleadosActivos? filtroEstado = filtroEmpleadosActivos.Ninguno,
									   OrdenarEmpleados? orden = OrdenarEmpleados.Ninguno);
		void Editar(Empleado e, SqlConnection conexion, SqlTransaction tran);
		void Agregar(Empleado e, SqlConnection conexion, SqlTransaction tran);

	}
}
