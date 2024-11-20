using FoodStore.Windows.Forms.Categorias;
using FoodStore.Windows.Forms.Clientes;
using FoodStore.Windows.Forms.Empleados;
using FoodStore.Windows.Forms.Empresas;
using FoodStore.Windows.Forms.Localidades;
using FoodStore.Windows.Forms.Paises;
using FoodStore.Windows.Forms.Productos;
using FoodStore.Windows.Forms.Provincias;
using FoodStore.Windows.Forms.SubCategorias;

namespace FoodStore.Windows.Forms
{
	public partial class frmPrincipal : Form
	{
		private static IServiceProvider? _serviceProvider;
		public frmPrincipal(IServiceProvider? serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void btnPaises_Click(object sender, EventArgs e)
		{
			var frm = new frmPaises(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnprovincias_Click(object sender, EventArgs e)
		{
			var frm = new frmProvincias(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnLocalidades_Click(object sender, EventArgs e)
		{
			var frm = new frmLocalidades(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnEmpleado_Click(object sender, EventArgs e)
		{
			var frm = new frmEmpleados(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnCategorias_Click(object sender, EventArgs e)
		{
			var frm = new fmrCategorias(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnSubCategorias_Click(object sender, EventArgs e)
		{
			var frm = new frmSubcategorias(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnEmpresas_Click(object sender, EventArgs e)
		{
			var frm = new frmEmpresas(_serviceProvider!);
			frm.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var frm = new frmClientes(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnProductos_Click(object sender, EventArgs e)
		{
			var frm = new frmProductos(_serviceProvider!);
			frm.ShowDialog();
		}
	}
}
