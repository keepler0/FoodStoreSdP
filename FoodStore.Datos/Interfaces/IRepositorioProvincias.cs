using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Interfaces
{
    public interface IRepositorioProvincias
    {
        void Agregar(Provincia p, SqlConnection conexion, 
                                  SqlTransaction tran);
        void Borrar(int id, SqlConnection conexion,
                            SqlTransaction tran);
        void Editar(Provincia p, SqlConnection conexion, 
                                 SqlTransaction tran);
        bool EstaRelacionado(int id, SqlConnection conexion,
                                     SqlTransaction? tran = null);
        bool Existe(Provincia p, SqlConnection conexion, 
                                 SqlTransaction? tran = null);
        Provincia? GetItem(int id, SqlConnection conexion, 
                                   SqlTransaction? tran = null);
        List<ProvinciaListDto> GetLista(SqlConnection conexion, 
                                        SqlTransaction? tran = null,
										Ordenar? ordenar = Ordenar.Ninguno,
									    Pais? pais = null);
		List<Provincia> GetListaPorPais(SqlConnection conexion, int paisId);
	}
}