using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Entidades
{
	public class Tamanio
	{
        public int TamanioId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Disponible { get; set; }
    }
}
