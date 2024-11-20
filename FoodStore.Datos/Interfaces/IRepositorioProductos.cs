using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioProductos
	{
		void Borrar(int id, SqlConnection conexion, SqlTransaction tran);
		bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
		bool Existe(Producto? producto, SqlConnection conexion, SqlTransaction? tran = null);
		Producto? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
		List<ProductoListDto>? GetLista(SqlConnection conexion, SqlTransaction? tran = null,
										string? filtroMarca = null,
										OrdenarProductos? ordenar = OrdenarProductos.Ninguno,
										Categoria? categoria = null,
										SubCategoria? subCategoria = null);
		void Editar(Producto? producto, SqlConnection conexion, SqlTransaction tran);
		void Agregar(Producto? producto, SqlConnection conexion, SqlTransaction tran);
	}
}
