using FoodStore.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Datos.Interfaces
{
    public interface IRepositorioCategorias
    {
		void Borrar(int id, SqlConnection conexion, SqlTransaction tran);
		bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
		bool Existe(Categoria c, SqlConnection conexion, SqlTransaction? tran = null);
		Categoria? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
		List<Categoria> GetLista(SqlConnection conexion, SqlTransaction? tran = null);
		void Editar(Categoria c, SqlConnection conexion, SqlTransaction tran );
		void Agregar(Categoria c,SqlConnection conexion,SqlTransaction tran);
	}
}
