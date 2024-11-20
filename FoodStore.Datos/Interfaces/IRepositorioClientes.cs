using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioClientes
	{
		void Borrar(int id, SqlConnection conexion, SqlTransaction tran);
		bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
		bool Existe(Cliente cl, SqlConnection conexion, SqlTransaction? tran = null);
		Cliente? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
		List<ClienteListDto> GetLista(SqlConnection conexion,SqlTransaction? tran = null,
									  string? nombre = null,
									  string? direccion = null,
									  OrdenarClientes? orden = OrdenarClientes.Ninguno);
		void Editar(Cliente cl, SqlConnection conexion, SqlTransaction tran);
		void Agregar(Cliente cl, SqlConnection conexion, SqlTransaction tran);
	}
}
