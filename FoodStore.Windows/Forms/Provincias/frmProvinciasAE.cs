using FoodStore.Entidades;
using FoodStore.Windows.Forms.Paises;
using FoodStore.Windows.Helpers;

namespace FoodStore.Windows.Forms.Provincias
{
	public partial class frmProvinciasAE : Form
	{
		private Provincia? _provincia;
		public Provincia? Provincia
		{
			get { return _provincia; }
			set { _provincia = value; }
		}
		private readonly IServiceProvider? _serviceProvider;
		private Pais? paisSeleccionado;
		public frmProvinciasAE(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarCombosPaises(ref cbxPaises, _serviceProvider);
			if (_provincia is not null)
			{
				cbxPaises.SelectedValue = _provincia.PaisId;
				tbxProvincia.Text = _provincia.NombreProvincia;
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
				if (_provincia is null)
				{
					_provincia = new Provincia();
				}
				_provincia.NombreProvincia = tbxProvincia.Text;
				_provincia.Pais = paisSeleccionado!;
				_provincia.PaisId = paisSeleccionado!.PaisId;
				DialogResult = DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(tbxProvincia.Text))
			{
				MessageHelper.Error("Debe introducir una provincia");
				return false;
			}
			if (cbxPaises.SelectedIndex == 0)
			{
				MessageHelper.Error("Debe seleccionar un pais");
				return false;
			}
			return true;
		}

		private void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
		{
			paisSeleccionado = cbxPaises.SelectedIndex > 0 ? (Pais?)
									   cbxPaises.SelectedItem : null;
		}

		private void btnAgregarPais_Click(object sender, EventArgs e)
		{
			var frm = new frmPaises(_serviceProvider!) { Text = "Agregar registro" };
			frm.ShowDialog();
			CombosHelper.CargarCombosPaises(ref cbxPaises, _serviceProvider);
		}

		private void frmProvinciasAE_Load(object sender, EventArgs e)
		{

		}
	}
}
