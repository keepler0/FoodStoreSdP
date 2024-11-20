using FoodStore.Entidades;
using FoodStore.Windows.Forms.Localidades;
using FoodStore.Windows.Forms.Paises;
using FoodStore.Windows.Forms.Provincias;
using FoodStore.Windows.Helpers;

namespace FoodStore.Windows.Forms.Clientes
{
	public partial class frmClientesAE : Form
	{
		private readonly IServiceProvider _serviceProvider;
		public frmClientesAE(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}
		private Cliente? _cliente;

		public Cliente? Cliente
		{
			get { return _cliente; }
			set { _cliente = value; }
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (_cliente is not null)
			{
				tbxNombre.Text = _cliente.Nombre;
				tbxApellido.Text = _cliente.Apellido;
				tbxTelefono.Text = _cliente.Telefono;
				tbxDni.Text = _cliente.DNI;
				tbxCalle1.Text = _cliente.Calle1;
				tbxCalle2.Text = _cliente.Calle2;
				tbxnumero.Text = _cliente.NumeroCasa;
			}
		}
		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				if (Validar())
				{
					if (_cliente is null)
					{
						_cliente = new Cliente();
					}
					_cliente.Nombre = tbxNombre.Text;
					_cliente.Apellido = tbxApellido.Text;
					_cliente.Telefono = tbxTelefono.Text;
					_cliente.DNI = tbxDni.Text;
					_cliente.Calle1 = tbxCalle1.Text;
					_cliente.Calle2 = tbxCalle2.Text;
					_cliente.NumeroCasa = tbxnumero.Text;
					DialogResult = DialogResult.OK;
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
				throw;
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(tbxNombre.Text))
			{
				MessageHelper.Error("Debe introducir algun nombre");
				return false;
			}
			return true;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
		private void btnAgregarPais_Click(object sender, EventArgs e)
		{
			var frm = new frmPaises(_serviceProvider);
			frm.ShowDialog();
		}

		private void btnAgregarProvincia_Click(object sender, EventArgs e)
		{
			var frm = new frmProvincias(_serviceProvider);
			frm.ShowDialog();
		}

		private void btnAgregarLocalidad_Click(object sender, EventArgs e)
		{
			var frm = new frmLocalidades(_serviceProvider);
			frm.ShowDialog();
		}

		private void frmClientesAE_Load(object sender, EventArgs e)
		{

		}
	}
}
