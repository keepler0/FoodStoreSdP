using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
    public interface IRepositorioLocalidades
    {
        void Agregar(Localidad p, SqlConnection conexion, SqlTransaction tran);
        void Borrar(int id, SqlConnection conexion, SqlTransaction tran);
        void Editar(Localidad p, SqlConnection conexion, SqlTransaction tran);
        bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null);
        bool Existe(Localidad p, SqlConnection conexion, SqlTransaction? tran = null);
        Localidad? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null);
        List<LocalidadListDto> GetLista(SqlConnection conexion, 
                                        SqlTransaction? tran = null,
										OrdenarLocalidades? ordenar = OrdenarLocalidades.Ninguno,
									    Pais? pais = null,
                                        Provincia? provincia=null);
		List<Localidad> GetListaPorProvincia(SqlConnection conexion, int id);
	}
}