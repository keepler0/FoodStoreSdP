using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Servicios.Interfaces
{
	public interface IServiciosGenericos<T>where T : class
	{
		void Guardar(T item);
		void Borrar(int id);
		bool Existe(T item);
		bool EstaRelacionado(int id);
		List<T> GetLista();
		T? GetItem(int id);
	}
}
