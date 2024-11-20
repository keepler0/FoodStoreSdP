using FoodStore.Entidades;
using FoodStore.Windows.Forms.Localidades;
using FoodStore.Windows.Forms.Paises;
using FoodStore.Windows.Forms.Provincias;
using FoodStore.Windows.Helpers;
using System.ComponentModel.Design;

namespace FoodStore.Windows.Forms.Empleados
{
	public partial class frmEmpleadosAE : Form
	{
		//TODO: falta configurar algunas cosas para poder hacer la edicion del registro
		private readonly IServiceProvider? _serviceProvider;
		private Rol? _rolSeleccted;
		private Empleado? _empleado;
		private string? imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\SinImagenDisponible.png";
		private string? archivoNoEncontrado=Environment.CurrentDirectory+ @"\Imagenes\ArchivoNoEncontrado.png";
		private string? archivoImagen = string.Empty;
		private string? carpetaImagen = Environment.CurrentDirectory + @"\Imagenes\";
		public Empleado? Empleado
		{
			get { return _empleado; }
			set { _empleado = value; }
		}
		public frmEmpleadosAE(IServiceProvider? serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarCombosRoles(ref cbxRoles, _serviceProvider);
			if (_empleado is not null)
			{
				tbxNombre.Text = _empleado.Nombre;
				tbxApellido.Text = _empleado.Apellido;
				tbxCuit.Text = _empleado.Cuit;
				tbxSueldo.Text = _empleado.Sueldo.ToString("C");
				tbxDireccion.Text = _empleado.Direccion;
				tbxTelefono.Text = _empleado.Telefono;
				cbxRoles.SelectedIndex = _empleado.RolId;
				chBxActivo.Checked = _empleado.Activo;
				archivoImagen = _empleado.Foto;
				if (!string.IsNullOrEmpty(_empleado.Foto))
				{
					var rutaImagen = Path.Combine(carpetaImagen!, _empleado.Foto);
					if (File.Exists(rutaImagen))
					{
						picFoto.Image=Image.FromFile(rutaImagen);
					}
					else
					{
						picFoto.Image = Image.FromFile(archivoNoEncontrado!);
					}
				}
				else
				{
					picFoto.Image = Image.FromFile(imagenNoDisponible!);
				}
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
				if (_empleado is null)
				{
					_empleado = new Empleado();
				}
				_empleado.Nombre = tbxNombre.Text;
				_empleado.Apellido = tbxApellido.Text;
				_empleado.Direccion = tbxDireccion.Text;
				_empleado.Telefono = tbxTelefono.Text;
				_empleado.Sueldo = decimal.Parse(tbxSueldo.Text);
				_empleado.Cuit = tbxCuit.Text;
				_empleado.Activo = chBxActivo.Checked;
				_empleado.Rol = _rolSeleccted;
				_empleado.RolId = _rolSeleccted!.RolId;
				_empleado.FechaContrato = dtpFechaContrato.Value;
				_empleado.Foto = archivoImagen;
				DialogResult = DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(tbxNombre.Text) ||
				string.IsNullOrEmpty(tbxApellido.Text))
			{
				MessageHelper.Error("El nombre y apellido son requeridos");
				return false;
			}
			if (string.IsNullOrEmpty(tbxCuit.Text))
			{
				MessageHelper.Error("El Cuit es requerido");
				return false;
			}
			if (string.IsNullOrEmpty(tbxDireccion.Text))
			{
				MessageHelper.Error("La direccion es requerida");
				return false;
			}
			if (string.IsNullOrEmpty(tbxTelefono.Text))
			{
				MessageHelper.Error("El numero telefonico es requerido");
				return false;
			}
			if (!decimal.TryParse(tbxSueldo.Text, out decimal s))
			{
				MessageHelper.Error("Debe ingresar el sueldo del empleado");
				return false;
			}
			if (cbxRoles.SelectedIndex == 0)
			{
				MessageHelper.Error("Debe seleccionar un cargo");
				return false;
			}
			return true;
		}

		private void btnAgregarPais_Click(object sender, EventArgs e)
		{
			var frm = new frmPaises(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnAgregarProvincia_Click(object sender, EventArgs e)
		{
			var frm = new frmProvincias(_serviceProvider!);
			frm.ShowDialog();
		}

		private void btnAgregarLocalidad_Click(object sender, EventArgs e)
		{
			var frm = new frmLocalidades(_serviceProvider!);
			frm.ShowDialog();
		}

		private void cbxRoles_SelectedIndexChanged(object sender, EventArgs e)
		{
			_rolSeleccted = cbxRoles.SelectedIndex > 0 ?
							cbxRoles.SelectedItem as Rol :
							null;
		}

		private void btnBuscarImagen_Click(object sender, EventArgs e)
		{
			openFileDialog1.Multiselect = false;
			openFileDialog1.InitialDirectory = carpetaImagen;
			openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png| Archivos jpeg (*.jpeg)|*.jpeg)";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory= true;
			var dr=openFileDialog1.ShowDialog(this);
			if (dr==DialogResult.OK)
			{
				if (openFileDialog1.FileName is null) return;
				picFoto.Image=Image.FromFile(openFileDialog1.FileName);
				archivoImagen = openFileDialog1.FileName;
			}
		}
	}
}
