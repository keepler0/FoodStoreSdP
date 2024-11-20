using FoodStore.Entidades;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioEmpresas
	{
		void Borrar(int id, SqlConnection conexion, SqlTransaction tran);
		bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
		bool Existe(Empresa? c, SqlConnection conexion, SqlTransaction? tran = null);
		Empresa? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
		List<Empresa>? GetLista(SqlConnection conexion,
								OrdenarEmpresas? orden = OrdenarEmpresas.Ninguno,
								string? textoFiltro = null,
								SqlTransaction? tran = null);
		void Editar(Empresa? c, SqlConnection conexion, SqlTransaction tran);
		void Agregar(Empresa? c, SqlConnection conexion, SqlTransaction tran);
	}
}
