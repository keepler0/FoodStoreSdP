using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
    public interface IRepositorioPaises
    {
        void Agregar(Pais p, SqlConnection conexion, SqlTransaction tran);
        void Borrar(int id, SqlConnection conexion, SqlTransaction? tran);
        void Editar(Pais p, SqlConnection conexion, SqlTransaction? tran);
        bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
        bool Existe(Pais p, SqlConnection conexion, SqlTransaction? tran = null);
        Pais? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
        List<Pais> GetLista(SqlConnection conexion, SqlTransaction? tran = null);
    }
}