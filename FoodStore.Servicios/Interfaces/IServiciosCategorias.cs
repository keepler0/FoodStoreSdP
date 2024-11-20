using FoodStore.Entidades;

namespace FoodStore.Servicios.Servicios
{
	public interface IServiciosCategorias
	{
		void Borrar(int id);
		bool EstaRelacionado(int id);
		bool Existe(Categoria c);
		Categoria? GetItem(int id);
		List<Categoria> GetLista();
		void Guardar(Categoria c);
	}
}