using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioSubCategorias
	{
		void Agregar(SubCategoria sc, SqlConnection conexion,
								  SqlTransaction tran);
		void Borrar(int id, SqlConnection conexion,
							SqlTransaction tran);
		void Editar(SubCategoria sc, SqlConnection conexion,
								 SqlTransaction tran);
		bool EstaRelacionado(int id, SqlConnection conexion,
									 SqlTransaction? tran = null);
		bool Existe(SubCategoria sc, SqlConnection conexion,
								 SqlTransaction? tran = null);
		SubCategoria? GetItem(int id, SqlConnection conexion,
								   SqlTransaction? tran = null);
		List<SubCategoriaListDto> GetLista(SqlConnection conexion,
										SqlTransaction? tran = null,
										OrdenarCategorias? ordenar = OrdenarCategorias.Ninguno,
										Categoria? c = null);
		List<SubCategoria> GetListaPorCategoria(SqlConnection conexion, int id);
	}
}
