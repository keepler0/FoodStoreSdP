using FoodStore.Entidades;
using FoodStore.Entidades.Enums;

namespace FoodStore.Servicios.Interfaces
{
	public interface IServiciosEmpresas
	{
		void Borrar(int id);
		bool EstaRelacionado(int id);
		bool Existe(Empresa? c);
		Empresa? GetItem(int id);
		List<Empresa>? GetLista(OrdenarEmpresas? orden= OrdenarEmpresas.Ninguno,
								string? textoFiltro=null);
		void Guardar(Empresa? c);
	}
}
