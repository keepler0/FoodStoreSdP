using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Empleados
{
	public partial class frmEmpleados : Form
	{
		private readonly IServiceProvider? _serviceProvider;
		private readonly IServiciosEmpleados? _servicios;
		private List<EmpleadoListDto>? lista;
		private string? filtroNombre = null, filtroApellido = null;
		private filtroEmpleadosActivos? filtroEstado = filtroEmpleadosActivos.Ninguno;
		private OrdenarEmpleados? orden = OrdenarEmpleados.Ninguno;
		private Rol? rolSeeleccionado = null;

		public frmEmpleados(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosEmpleados>();
		}

		private void frmEmpleados_Load(object sender, EventArgs e)
		{
			CombosHelper.CargarCombosRoles(ref cbxCargos, _serviceProvider);
			CombosHelper.CargarCombosOrden(ref cbxOrdenar, orden);
			CombosHelper.CargarCombosEstados(ref cbxEstadoEmpleado, filtroEstado);
			RecargarGrilla();
		}

		private void RecargarGrilla(string? filtroNombre = null, string? filtroApellido = null, Rol? rol = null,
									filtroEmpleadosActivos? filtroEstado = filtroEmpleadosActivos.Ninguno,
									OrdenarEmpleados? orden = OrdenarEmpleados.Ninguno)
		{
			lista = _servicios!.GetLista(filtroNombre, filtroApellido, rol, filtroEstado, orden);
			CargarGrilla();
		}

		private void CargarGrilla()
		{
			GridHelper.LimpiarGrilla(dgvDatos);
			foreach (var item in lista!)
			{
				var r = GridHelper.ConstruirFila(dgvDatos);
				GridHelper.SetFila(r, item);
				GridHelper.AgregarFila(dgvDatos, r);
			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			var frm = new frmEmpleadosAE(_serviceProvider!) { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var empleado = frm.Empleado!;
				EmpleadoListDto? empleadoDto = empleado;
				if (!_servicios!.Existe(empleado!))
				{
					_servicios.Guardar(empleado!);

					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, empleadoDto!);
					GridHelper.AgregarFila(dgvDatos, r);
					MessageHelper.Information("Registro agregado correctamente");
					CombosHelper.CargarCombosPaises(ref cbxCargos, _serviceProvider);
				}
				else
				{
					MessageHelper.Error($"{empleadoDto.NombreCompleto} ya existe en el registro");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) return;
			var r = dgvDatos.SelectedRows[0];
			var eDto = r.Tag as EmpleadoListDto;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {eDto!.NombreCompleto} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(eDto.EmpleadoId))
				{
					_servicios.Borrar(eDto.EmpleadoId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {eDto!.NombreCompleto} del registro");
				}
				else
				{
					MessageHelper.Error($"{eDto.NombreCompleto} esta relacionado con otros registros, eliminacion denegada");
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
			var empleadoDto = r.Tag as EmpleadoListDto;
			var dr = MessageHelper.Question($"Esta seguro de editar {empleadoDto!.NombreCompleto}?");
			if (dr == DialogResult.No) return;
			try
			{
				var frm = new frmEmpleadosAE(_serviceProvider!) { Text = "Editando registro" };
				Empleado? empleado = _servicios!.GetItem(empleadoDto.EmpleadoId)!;
				frm.Empleado = empleado;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				empleado = frm.Empleado;
				empleadoDto = empleado;
				if (!_servicios!.Existe(empleado))
				{
					_servicios.Guardar(empleado);
					GridHelper.SetFila(r, empleadoDto);
					MessageHelper.Information($"Se ha editado {empleadoDto!.NombreCompleto} del registro");
				}
				else
				{
					MessageHelper.Error($"{empleadoDto.NombreCompleto} ya existe en los registros");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}

		private void btnActualiza_Click(object sender, EventArgs e)
		{
			RecargarGrilla();
			tbxApellido.Clear();
			filtroApellido = null;
			tbxNombre.Clear();
			filtroNombre = null;
			cbxOrdenar.SelectedIndex = 0;
			cbxCargos.SelectedIndex = 0;
		}

		private void btnBuscarNombre_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbxNombre.Text)) return;
			filtroNombre = tbxNombre.Text;
			RecargarGrilla(filtroNombre, filtroApellido, rolSeeleccionado, filtroEstado, orden);
		}

		private void btnBuscarApellido_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbxApellido.Text)) return;
			filtroApellido = tbxApellido.Text;
			RecargarGrilla(filtroNombre, filtroApellido, rolSeeleccionado, filtroEstado, orden);
		}

		private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxOrdenar.SelectedIndex > 0)
			{
				orden = (OrdenarEmpleados)cbxOrdenar.SelectedItem!;
				RecargarGrilla(filtroNombre, filtroApellido, rolSeeleccionado, filtroEstado, orden);
				btnQuitarOrden.Enabled = true;
			}
		}

		private void btnQuitarOrden_Click(object sender, EventArgs e)
		{
			orden = OrdenarEmpleados.Ninguno;
			cbxOrdenar.SelectedIndex = 0;
			btnQuitarOrden.Enabled = false;
			RecargarGrilla(filtroNombre, filtroApellido, rolSeeleccionado, filtroEstado, orden);
		}

		private void cbxCargos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxCargos.SelectedIndex > 0)
			{
				rolSeeleccionado = cbxCargos.SelectedItem as Rol;
				RecargarGrilla(filtroNombre, filtroApellido, rolSeeleccionado, filtroEstado, orden);
				btnQuitarCargo.Enabled = true;
			}
		}

		private void btnQuitarCargo_Click(object sender, EventArgs e)
		{
			rolSeeleccionado = null;
			cbxCargos.SelectedIndex = 0;
			RecargarGrilla(filtroNombre, filtroApellido, rolSeeleccionado, filtroEstado, orden);
			btnQuitarCargo.Enabled = false;
		}

		private void cbxEstadoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxEstadoEmpleado.SelectedIndex > 0)
			{
				filtroEstado = (filtroEmpleadosActivos)cbxEstadoEmpleado.SelectedItem!;
				RecargarGrilla(filtroNombre, filtroApellido, rolSeeleccionado, filtroEstado, orden);
				btnQuitarEstado.Enabled = true;
			}
		}

		private void btnQuitarEstado_Click(object sender, EventArgs e)
		{
			filtroEstado = filtroEmpleadosActivos.Ninguno;
			cbxCargos.SelectedIndex = 0;
			RecargarGrilla(filtroNombre, filtroApellido, rolSeeleccionado, filtroEstado, orden);
			btnQuitarCargo.Enabled = false;
		}
	}
}
