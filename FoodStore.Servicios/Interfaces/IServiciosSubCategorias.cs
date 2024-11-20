using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;

namespace FoodStore.Servicios.Interfaces
{
	public interface IServiciosSubCategorias
	{
		void Borrar(int id);
		bool EstaRelacionado(int id);
		bool Existe(SubCategoria sc);
		SubCategoria? GetItem(int id);
		List<SubCategoriaListDto> GetLista(OrdenarCategorias? orden= OrdenarCategorias.Ninguno,Categoria? categoria = null);
		List<SubCategoria> GetListaPorCategoria(int categoriaId);
		void Guardar(SubCategoria sc);
	}
}
