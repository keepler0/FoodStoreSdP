using FoodStore.Entidades;
using FoodStore.Windows.Helpers;

namespace FoodStore.Windows.Forms.Paises
{
	public partial class frmPaisesAE : Form
	{
		private Pais? _pais;

		public Pais? Pais
		{
			get { return _pais; }
			set { _pais = value; }
		}

		public frmPaisesAE()
		{
			InitializeComponent();
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (_pais is not null)
			{
				tbxPais.Text = _pais.NombrePais;
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
				if (Pais is null)
				{
					Pais = new Pais();
				}
				Pais.NombrePais = tbxPais.Text;
				DialogResult=DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(tbxPais.Text))
			{
				MessageHelper.Error("Debe ingresar un nombre de pais");
				return false;
			}
			return true;
		}
	}
}
