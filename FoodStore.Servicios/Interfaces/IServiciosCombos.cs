using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Servicios.Interfaces
{
    public interface IServiciosCombos
    {
		void Borrar(int id);
		bool EstaRelacionado(int id);
		bool Existe(Combo? combo);
		Combo? GetItem(int id);
		List<ComboListDto>? GetLista();
		void Guardar(Combo? combo);
	}
}
