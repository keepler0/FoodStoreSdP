using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;

namespace FoodStore.Servicios.Interfaces
{
	public interface IServiciosProductos
	{
		void Borrar(int id);
		bool EstaRelacionado(int id);
		bool Existe(Producto? producto);
		Producto? GetItem(int id);
		List<ProductoListDto>? GetLista(string? filtroMarca = null,
									OrdenarProductos? ordenar = OrdenarProductos.Ninguno,
									Categoria? categoria = null,
									SubCategoria? subCategoria = null);
		List<Producto> GetListaPorCategoria(int categoriaId);
		List<Producto>? GetListaProductos();
		void Guardar(Producto? producto);
	}
}
