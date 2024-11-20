using FoodStore.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStore.Windows.Forms.Clientes
{
	public partial class frmVerCliente : Form
	{
		public frmVerCliente()
		{
			InitializeComponent();
		}
		private Cliente? _cliente;

		public Cliente? Cliente
		{
			set { _cliente = value; }
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (_cliente is null) return;
			lblNombre.Text = $"{_cliente.Nombre} {_cliente.Apellido}";
			lblDireccion.Text = $"{_cliente.Calle1} {_cliente.Calle2}";
			lblNumero.Text = $"{_cliente.NumeroCasa}";
			lblTelefono.Text = $"{_cliente.Telefono}";
		}
		private void lblSalir_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
