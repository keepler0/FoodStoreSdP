using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStore.Windows.UsersControls
{
	public partial class ucProducto : UserControl
	{
		public ucProducto()
		{
			InitializeComponent();
		}
		public int ProductoId { get; set; }
		public string NombreProducto { set => lblNombreProducto.Text = value; }
		public decimal PrecioProducto { set => lblPrecioProducto.Text = value.ToString(); }
		public string ImagenProducto { get; set; }

	}
}
