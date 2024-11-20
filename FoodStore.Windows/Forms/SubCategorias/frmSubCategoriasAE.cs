using FoodStore.Entidades;
using FoodStore.Windows.Forms.Categorias;
using FoodStore.Windows.Helpers;

namespace FoodStore.Windows.Forms.SubCategorias
{
	public partial class frmSubCategoriasAE : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private Categoria? _categoria;
		private SubCategoria? _subCategoria;

		public SubCategoria? SubCategoria
		{
			get { return _subCategoria; }
			set { _subCategoria = value; }
		}

		public frmSubCategoriasAE(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarCombosCategorias(ref cbxCategorias, _serviceProvider);
			if (_subCategoria is not null)
			{
				cbxCategorias.SelectedValue = _subCategoria.CategoriaId;
				tbxSubCategoria.Text = _subCategoria.NombreSubCategoria;
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
				if (_subCategoria is null)
				{
					_subCategoria = new SubCategoria();
				}
				_subCategoria.NombreSubCategoria = tbxSubCategoria.Text;
				_subCategoria.Categoria = _categoria;
				_subCategoria.CategoriaId = _categoria!.CategoriaId;
				DialogResult = DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (cbxCategorias.SelectedIndex == 0)
			{
				MessageHelper.Error("Debe seleccionar una categoria");
				return false;
			}
			if (string.IsNullOrEmpty(tbxSubCategoria.Text))
			{
				MessageHelper.Error("Debe ingresar el nombre de la sub-categoria");
				return false;
			}
			return true;
		}

		private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
		{
			_categoria = cbxCategorias.SelectedIndex > 0 ? cbxCategorias.SelectedItem as Categoria
														: null;
		}

		private void btnAgregarCategoria_Click(object sender, EventArgs e)
		{
			var frm = new fmrCategorias(_serviceProvider);
			frm.ShowDialog();
			CombosHelper.CargarCombosCategorias(ref cbxCategorias, _serviceProvider);
		}
	}
}
