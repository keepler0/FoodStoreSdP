using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Forms.Empleados;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Clientes
{
	public partial class frmClientes : Form
	{
		private readonly IServiceProvider? _serviceProvider;
		private readonly IServiciosClientes? _servicios;
		private List<ClienteListDto>? _lista;
		private string? filtroNombre = null;
		private string? filtroDireccion = null;
		private OrdenarClientes? orden = OrdenarClientes.Ninguno;
		public frmClientes(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosClientes>();
		}

		private void frmClientes_Load(object sender, EventArgs e)
		{
			RecargarGrilla();
			CombosHelper.CargarCombosOrden(ref cbxOrdenar, orden);
		}

		private void RecargarGrilla(string? nombre = null,
									string? direccion = null,
									OrdenarClientes? orden = OrdenarClientes.Ninguno)
		{
			_lista = _servicios!.GetLista(nombre, direccion, orden);
			CargarGrilla();
		}
		private void CargarGrilla()
		{
			GridHelper.LimpiarGrilla(dgvDatos);
			foreach (var item in _lista!)
			{
				var r = GridHelper.ConstruirFila(dgvDatos);
				GridHelper.SetFila(r, item);
				GridHelper.AgregarFila(dgvDatos, r);
			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			var frm = new frmClientesAE(_serviceProvider!) { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var cliente = frm.Cliente!;
				ClienteListDto? clienteDto = cliente;
				if (!_servicios!.Existe(cliente!))
				{
					_servicios.Guardar(cliente!);

					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, clienteDto!);
					GridHelper.AgregarFila(dgvDatos, r);
					MessageHelper.Information("Registro agregado correctamente");
				}
				else
				{
					MessageHelper.Error($"{clienteDto.NombreCompleto} ya existe en el registro");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}

		private void btnDatos_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) return;
			var r = dgvDatos.SelectedRows[0];
			var clienteDto = r.Tag as ClienteListDto;
			var cliente = _servicios!.GetItem(clienteDto!.ClienteId);
			var frm = new frmVerCliente();
			frm.Cliente = cliente;
			frm.Show(this);
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) return;
			var r = dgvDatos.SelectedRows[0];
			var clienteDto = r.Tag as ClienteListDto;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {clienteDto!.NombreCompleto} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(clienteDto.ClienteId))
				{
					_servicios.Borrar(clienteDto.ClienteId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {clienteDto!.NombreCompleto} del registro");
				}
				else
				{
					MessageHelper.Error($"{clienteDto.NombreCompleto} esta relacionado con otros registros, eliminacion denegada");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) return;
			var r = dgvDatos.SelectedRows[0];
			var clienteDto = r.Tag as ClienteListDto;
			var dr = MessageHelper.Question($"Esta seguro de editar {clienteDto!.NombreCompleto}?");
			if (dr == DialogResult.No) return;
			try
			{
				var frm = new frmClientesAE(_serviceProvider!) { Text = "Editando registro" };
				Cliente? cliente = _servicios!.GetItem(clienteDto.ClienteId)!;
				frm.Cliente = cliente;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				cliente = frm.Cliente;
				clienteDto = cliente;
				if (!_servicios!.Existe(cliente))
				{
					_servicios.Guardar(cliente);
					GridHelper.SetFila(r, clienteDto);
					MessageHelper.Information($"Se ha editado {clienteDto!.NombreCompleto} del registro");
				}
				else
				{
					MessageHelper.Error($"{clienteDto.NombreCompleto} ya existe en los registros");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
		{
			var dr = MessageHelper.Question("Esta seguro de cerrar el registro de clientes?");
			if (dr == DialogResult.No) e.Cancel = true;
		}

		private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxOrdenar.SelectedIndex > 0)
			{
				orden = (OrdenarClientes)cbxOrdenar.SelectedItem!;
				RecargarGrilla(filtroNombre, filtroDireccion, orden);
				btnQuitarOrden.Enabled = true;
			}
		}

		private void btnQuitarOrden_Click(object sender, EventArgs e)
		{
			orden = OrdenarClientes.Ninguno;
			cbxOrdenar.SelectedIndex = 0;
			RecargarGrilla(filtroNombre, filtroDireccion, orden);
			btnQuitarOrden.Enabled = false;
		}

		private void btnBucarApellido_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbxDireccion.Text))
			{
				filtroDireccion = tbxDireccion.Text;
				RecargarGrilla(filtroNombre, filtroDireccion, orden);
			}
		}


		private void btnBuscarNombre_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbxNombre.Text))
			{
				filtroNombre = tbxNombre.Text;
				RecargarGrilla(filtroNombre, filtroDireccion, orden);
			}
		}

		private void btnActualiza_Click(object sender, EventArgs e)
		{
			orden = OrdenarClientes.Ninguno;
			cbxOrdenar.SelectedIndex = 0;
			tbxNombre.Clear();
			filtroNombre = null;
			tbxDireccion.Clear();
			filtroDireccion = null;
			btnQuitarOrden.Enabled= false;
			RecargarGrilla(filtroNombre, filtroDireccion, orden);
		}
	}
}
