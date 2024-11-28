using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Combos
{
	public partial class frmCombosAE : Form
	{
		private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\SinImagenDisponible.png";
		private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imagenes\ArchivoNoEncontrado.png";
		private string? archivoImagen = string.Empty;
		private string carpetaImagen = Environment.CurrentDirectory + @"\Imagenes\";
		private readonly IServiceProvider? _serviceProvider;
		private readonly IServiciosProductos _servicios;
		private Combo? combo;
		private Tamanio tamanioSeleccionado;
		private decimal precio = 0;

		public Combo? Combo
		{
			get { return combo; }
			set { combo = value; }
		}

		public frmCombosAE(IServiceProvider? serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider!.GetService<IServiciosProductos>()!;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarCombosTamanios(ref cbxTamanio, _serviceProvider);
			if (combo is null)
			{
				combo = new Combo();
			}
			tbxNombre.Text = combo.NombreCombo;
			tbxDescripcion.Text = combo.Descripcion;
			cbxTamanio.SelectedValue = combo.TamanioId;
			//dtpInicio.Value = combo.FechaInicio;
			//dtpFin.Value= combo.FechaFin is null? dtpFin.Enabled = false: combo.FechaFin;
			tbxPrecio.Text = combo.PrecioCombo.ToString();
		}
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			var frm = new frmManejadorDeProductos(_serviceProvider) { Text = "Agregar producto" };
			var dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) return;
			var comboProducto = frm.ComboProducto;
			if (comboProducto is null) return;
			if (combo!.Existe(comboProducto))
			{
				dr = MessageHelper.Question($"Desea agregar la cantidad {comboProducto.Producto!.Descripcion}?");
				if (dr == DialogResult.Yes)
				{
					combo.Agregar(comboProducto);
					
				}
			}
			else
			{
				combo.Agregar(comboProducto);
			}
			precio += comboProducto.Producto.PrecioFinal*comboProducto.Cantidad;
			tbxPrecio.Text = precio.ToString();

			var r = GridHelper.ConstruirFila(dgvDatos);
			GridHelper.SetFila(r, comboProducto);
			GridHelper.AgregarFila(dgvDatos, r);
			//GridHelper.MostrarDatosEnGrilla<ComboProducto>(combo.Detalles, dgvDatos);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (Validar())
			{
				combo!.NombreCombo = tbxNombre.Text;
				combo.Descripcion = tbxDescripcion.Text;
				combo.FechaInicio = dtpInicio.Value;
				combo.FechaFin = dtpFin.Value;
				combo.PrecioCombo = decimal.Parse(tbxPrecio.Text);
				combo.TamanioId = tamanioSeleccionado.TamanioId;
				combo.Tamanio = tamanioSeleccionado;
				combo.Imagen = archivoImagen;
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(tbxNombre.Text))
			{
				MessageHelper.Error("Debe ingresar el nombre del combo");
				return false;
			}
			if (dgvDatos.Rows.Count == 0)
			{
				MessageHelper.Error("Debe agregar productos al combo");
				return false;
			}
			return true;
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) return;
			var r = dgvDatos.SelectedRows[0];
			var comboProducto = r.Tag as ComboProducto;
			var dr = MessageHelper.Question("Desea quitar el producto?");
			if (dr == DialogResult.No) return;
			try
			{
				combo!.Eliminar(comboProducto!);
				GridHelper.EliminarFila(dgvDatos, r);
				precio -= comboProducto!.Producto!.PrecioFinal*comboProducto.Cantidad;
				tbxPrecio.Text = precio.ToString();
			}
			catch (Exception)
			{
				throw;
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) return;
			var r = dgvDatos.SelectedRows[0];
			var comboProducto = r.Tag as ComboProducto;
			var frm = new frmManejadorDeProductos(_serviceProvider);
			frm.ComboProducto = comboProducto;
			frm.ShowDialog();
		}
	}
}
