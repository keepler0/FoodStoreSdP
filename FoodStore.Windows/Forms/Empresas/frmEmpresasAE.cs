using FoodStore.Entidades;
using FoodStore.Windows.Helpers;

namespace FoodStore.Windows.Forms.Empresas
{
	public partial class frmEmpresasAE : Form
	{
		private Empresa? _empresa;
		private Pais? paisSeleccionado;
		private Provincia? provinciaSeleccionada;
		private Localidad? localidadSeleccionada;
		private readonly IServiceProvider _serviceProvider;
		public frmEmpresasAE(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		public Empresa? Empresa
		{
			get { return _empresa; }
			set { _empresa = value; }
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarCombosPaises(ref cbxPaises, _serviceProvider);
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				if (Validar())
				{
					string direccion=ConstruirDireccion();
					if (_empresa is null)
					{
						_empresa = new Empresa();
					}
					_empresa.RazonSocial = tbxRazonSocial.Text;
					_empresa.Direccion = direccion;
					_empresa.Telefono = tbxTelefono.Text;
					_empresa.Email = tbxEmail.Text;
					_empresa.Cuit = tbxCuit.Text;
					DialogResult = DialogResult.OK;
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
				if (ex.Message.Contains("Cuit"))
				{
					tbxCuit.Focus();
					tbxCuit.SelectAll();
				}
			}
		}

		private string ConstruirDireccion()
		{
			string m=string.Empty;
			if (!string.IsNullOrEmpty(tbxCalle1.Text))
			{
				m= tbxCalle1.Text+",";
			}
			if (!string.IsNullOrEmpty(tbxCalle2.Text))
			{
				m+= tbxCalle2.Text + ",";
			}
			if (!string.IsNullOrEmpty(tbxNumero.Text))
			{
				m += tbxNumero.Text + ",";
			}
			if (!string.IsNullOrEmpty(cbxLocalidades.SelectedText))
			{
				m += cbxLocalidades.SelectedText;
			}
			return m;
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(tbxRazonSocial.Text))
			{
				MessageHelper.Error("Debe introducir la Razon social de la empresa");
				return false;
			}
			return true;
		}

		private void tbxCuit_TextChanged(object sender, EventArgs e)
		{
			tbxCuit.TextChanged -= tbxCuit_TextChanged!;
			int cursorPosition = tbxCuit.SelectionStart;
			if (tbxCuit.Text.Length == 3 && !tbxCuit.Text.Contains("-"))
			{
				tbxCuit.Text = tbxCuit.Text.Insert(2, "-");
				cursorPosition++;
			}
			else if (tbxCuit.Text.Length == 12 && tbxCuit.Text.Count(c => c == '-') == 1)
			{
				tbxCuit.Text = tbxCuit.Text.Insert(11, "-");
				cursorPosition++;
			}
			tbxCuit.SelectionStart = cursorPosition;
			tbxCuit.TextChanged += tbxCuit_TextChanged!;
		}

		private void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
		{
			paisSeleccionado = cbxPaises.SelectedIndex > 0 ? cbxPaises.SelectedItem as Pais
													  : null;
			if (paisSeleccionado is not null)
			{
				CombosHelper.CargarCombosProvincias(ref cbxProvincias, _serviceProvider, paisSeleccionado);
			}
		}

		private void cbxProvincias_SelectedIndexChanged(object sender, EventArgs e)
		{
			provinciaSeleccionada = cbxProvincias.SelectedIndex > 0 ? cbxProvincias.SelectedItem as Provincia
													  : null;
			if (provinciaSeleccionada is not null)
			{
				CombosHelper.CargarCombosLocalidades(ref cbxLocalidades, _serviceProvider, provinciaSeleccionada);
			}
		}

		private void cbxLocalidades_SelectedIndexChanged(object sender, EventArgs e)
		{
			localidadSeleccionada = cbxLocalidades.SelectedIndex > 0 ? cbxLocalidades.SelectedItem as Localidad : null;

		}
	}
}
