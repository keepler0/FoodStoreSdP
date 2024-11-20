using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Entidades
{
	public class Detalle
	{
		private int _detalleId;
		private int _comboId;
		private int _productoId;
		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}


		public int ProductoId
		{
			get { return _productoId; }
			set { _productoId = value; }
		}


		public int ComboId
		{
			get { return _comboId; }
			set { _comboId = value; }
		}


		public int DetalleId
		{
			get { return _detalleId; }
			set { _detalleId = value; }
		}

	}
}
