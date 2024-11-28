using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Datos.Interfaces
{
	public interface IRepositorioCombos
	{
		void Agregar(Combo? combo, SqlConnection conexion, SqlTransaction tran);
		void Borrar(int id, SqlConnection conexion, SqlTransaction? tran);
		void Editar(Combo? combo, SqlConnection conexion, SqlTransaction? tran);
		bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
		bool Existe(Combo? combo, SqlConnection conexion, SqlTransaction? tran = null);
		Combo? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
		List<ComboListDto>? GetLista(SqlConnection conexion, SqlTransaction? tran = null);
	}
}
