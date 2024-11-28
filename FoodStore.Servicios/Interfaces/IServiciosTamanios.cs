using FoodStore.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Servicios.Interfaces
{
	public interface IServiciosTamanios
	{
		List<Tamanio> GetLista();
	}
}
