using FoodStore.Entidades.Dtos;
using FoodStore.Entidades;
using FoodStore.Entidades.Enums;

namespace FoodStore.Servicios.Interfaces
{
	public interface IServiciosClientes
	{
		void Borrar(int id);
		bool EstaRelacionado(int id);
		bool Existe(Cliente cl);
		Cliente? GetItem(int id);
		List<ClienteListDto> GetLista(string? nombre = null,
									  string? direccion = null,
									  OrdenarClientes? orden = OrdenarClientes.Ninguno);
		void Guardar(Cliente cl);
	}
}
