using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Helpers;
using System.ComponentModel;

namespace FoodStore.Windows.Forms.Combos
{
	public partial class frmManejadorDeProductos : Form
	{
		private readonly IServiceProvider? _serviceProvider;
		private ComboProducto? _comboProducto;
		private Categoria? categoriaSeleccionda;
		private Producto? ProductoSeleccionado;

		public ComboProducto? ComboProducto
		{
			get { return _comboProducto; }
			set { _comboProducto = value; }
		}


		public frmManejadorDeProductos(IServiceProvider? serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;

		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarCombosCategorias(ref cbxCategoria, _serviceProvider!);
			if (_comboProducto is not null)
			{
				cbxCategoria.SelectedValue = _comboProducto.Producto!.CategoriaId;
				CombosHelper.CargarCombosProductos(ref cbxProductos, _serviceProvider, _comboProducto.CategoriaId);
				cbxProductos.SelectedValue = _comboProducto.ProductoId;
				nudCantidad.Value = _comboProducto.Cantidad;
			}
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (Validar())
			{
				if (_comboProducto is null)
				{
					_comboProducto = new ComboProducto();
				}
				_comboProducto.ProductoId = ProductoSeleccionado!.ProductoId;
				_comboProducto.Cantidad = (int)nudCantidad.Value;
				_comboProducto.Producto = ProductoSeleccionado;
				DialogResult = DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (cbxCategoria.SelectedIndex == 0)
			{
				MessageHelper.Error("Debe seleccionar alguna categoria");
				return false;
			}
			if (cbxProductos.SelectedIndex == 0)
			{
				MessageHelper.Error("Debe seleccionar algun producto");
				return false;
			}
			if (nudCantidad.Value==0)
			{
				MessageHelper.Error("Debe ingresar la cantidad deseada");
				return false;
			}
			return true;
		}

		private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxCategoria.SelectedIndex > 0)
			{
				categoriaSeleccionda = cbxCategoria.SelectedItem as Categoria;
				CombosHelper.CargarCombosProductos(ref cbxProductos, _serviceProvider, categoriaSeleccionda!.CategoriaId);
			}
		}

		private void cbxSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbxProductos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxProductos.SelectedIndex>0)
			{
				ProductoSeleccionado = cbxProductos.SelectedItem as Producto;
			}
		}
	}
}
