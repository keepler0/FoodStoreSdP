using FoodStore.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStore.Windows.Forms.Productos
{
	public partial class frmVerProducto : Form
	{
		private Producto? _producto;

		public Producto? Producto
		{
			get { return _producto; }
			set { _producto = value; }
		}

		public frmVerProducto()
		{
			InitializeComponent();
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmVerProducto_Load(object sender, EventArgs e)
		{
			if (_producto is not null)
			{
				lblMarca.Text = _producto.Marca;
				lblDescripcion.Text = _producto.Descripcion;
			}
		}
	}
}
