using FoodStore.Entidades;
using FoodStore.Windows.Helpers;

namespace FoodStore.Windows.Forms.Categorias
{
	public partial class frmCategoriasAE : Form
	{
		private Categoria? _categoria;
		public Categoria? Categoria
		{
			get { return _categoria; }
			set { _categoria = value; }
		}

		public frmCategoriasAE()
		{
			InitializeComponent();
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (_categoria is not null)
			{
				txtCategoria.Text = _categoria.NombreCategoria;
			}
		}
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (Validar())
			{
				if (_categoria is null)
				{
					_categoria = new Categoria();
				}
				_categoria.NombreCategoria = txtCategoria.Text;
				DialogResult = DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(txtCategoria.Text))
			{
				MessageHelper.Error("Debe ingresar alguna categoria");
				return false;
			}
			return true;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
