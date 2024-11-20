using FoodStore.Entidades;
using FoodStore.Windows.Forms.Paises;
using FoodStore.Windows.Forms.Provincias;
using FoodStore.Windows.Helpers;

namespace FoodStore.Windows.Forms.Localidades
{
	public partial class frmLocalidadesAE : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private Localidad? _localidad;
		private Provincia? prSeleccionada = null;
		private Pais? paisSeleccionado = null;
		public Localidad? Localidad
		{
			get { return _localidad; }
			set { _localidad = value; }
		}

		public frmLocalidadesAE(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarCombosPaises(ref cbxPaises, _serviceProvider);
			if (_localidad is not null)
			{
				tbxLocalidad.Text = _localidad.NombreLocalidad;
				cbxPaises.SelectedIndex = _localidad.Provincia!.PaisId;
				cbxProvincias.SelectedIndex = _localidad.ProvinciaId;
			}

		}
		private void frmLocalidadesAE_Load(object sender, EventArgs e)
		{

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (Validar())
			{
				if (_localidad is null)
				{
					_localidad = new Localidad();
				}
				_localidad.NombreLocalidad = tbxLocalidad.Text;
				_localidad.Provincia = prSeleccionada;
				_localidad.ProvinciaId = prSeleccionada!.ProvinciaId;
				_localidad.Provincia!.Pais = paisSeleccionado!;
				DialogResult = DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (cbxPaises.SelectedIndex == 0)
			{
				MessageHelper.Error("Debe seleccionar un pais");
				return false;
			}
			if (cbxProvincias.SelectedIndex == 0)
			{
				MessageHelper.Error("Debe seleccionar una provincia");
				return false;
			}
			if (string.IsNullOrEmpty(tbxLocalidad.Text))
			{
				MessageHelper.Error("Debe ingresar una localidad");
				return false;
			}
			return true;
		}

		private void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
		{
			paisSeleccionado = cbxPaises.SelectedIndex != 0 ? cbxPaises.SelectedItem as Pais : null;
			if (paisSeleccionado is not null)
			{
				CombosHelper.CargarCombosProvincias(ref cbxProvincias,
													_serviceProvider,
													paisSeleccionado);
			}
			else
			{
				cbxProvincias.DataSource = null;
			}
		}

		private void cbxProvincias_SelectedIndexChanged(object sender, EventArgs e)
		{
			prSeleccionada = cbxProvincias.SelectedIndex != 0 ?
							 cbxProvincias.SelectedItem as Provincia :
							 null;
		}

		private void btnAgregarPais_Click(object sender, EventArgs e)
		{
			var frm = new frmPaises(_serviceProvider) { Text = "Agregando nuevo registro" };
			frm.ShowDialog();
		}

		private void btnAgregarProvincia_Click(object sender, EventArgs e)
		{
			var frm = new frmProvincias(_serviceProvider) { Text = "Agregando nuevo registro" };
			frm.ShowDialog();
		}
	}
}
