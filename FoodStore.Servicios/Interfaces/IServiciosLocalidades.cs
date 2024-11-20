using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;

namespace FoodStore.Servicios.Interfaces
{
    public interface IServiciosLocalidades
    {
        void Borrar(int id);
        bool EstaRelacionado(int id);
        bool Existe(Localidad c);
        Localidad? GetItem(int id);
        List<LocalidadListDto> GetLista(OrdenarLocalidades? ordenar = OrdenarLocalidades.Ninguno,
									    Pais? pais = null,
										Provincia? provincia = null);
		List<Localidad> GetListaPorProvincia(int provinciaId);
		void Guardar(Localidad c);
    }
}