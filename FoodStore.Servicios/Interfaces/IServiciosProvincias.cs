using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;


namespace FoodStore.Servicios.Interfaces
{
    public interface IServiciosProvincias
    {
        void Borrar(int id);
        bool EstaRelacionado(int id);
        bool Existe(Provincia c);
        Provincia? GetItem(int id);
        List<ProvinciaListDto> GetLista(Ordenar? ordenar=Ordenar.Ninguno,Pais? pais=null);
        List<Provincia> GetListaPorPais(int PaisId);
        void Guardar(Provincia c);
    }
}