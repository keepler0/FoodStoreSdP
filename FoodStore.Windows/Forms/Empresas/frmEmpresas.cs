using FoodStore.Entidades;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Empresas
{
	public partial class frmEmpresas : Form
	{
		private readonly IServiceProvider? _serviceProvider;
		private readonly IServiciosEmpresas? _servicios;
		private List<Empresa>? lista;
		private OrdenarEmpresas? orden = OrdenarEmpresas.Ninguno;
		private string textoFiltro = string.Empty;

		public frmEmpresas(IServiceProvider? serviceProvide)
		{
			InitializeComponent();
			_serviceProvider = serviceProvide;
			_servicios = _serviceProvider!.GetService<IServiciosEmpresas>();
		}
		private void frmEmpresas_Load(object sender, EventArgs e)
		{
			CombosHelper.CargarCombosOrden(ref cbxOrdenar, orden);
			RecargarGrilla();
		}

		private void RecargarGrilla(OrdenarEmpresas? ordenar = OrdenarEmpresas.Ninguno,
									string? textoFiltro = null)
		{
			lista = _servicios!.GetLista(ordenar, textoFiltro);
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

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			var frm = new frmEmpresasAE(_serviceProvider!) { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var em = frm.Empresa!;
				if (!_servicios!.Existe(em!))
				{
					_servicios.Guardar(em!);

					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, em!);
					GridHelper.AgregarFila(dgvDatos, r);
					MessageHelper.Information("Registro agregado correctamente");
				}
				else
				{
					MessageHelper.Error($"{em.RazonSocial} ya existe en el registro");
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
			var em = r.Tag as Empresa;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {em!.RazonSocial} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(em.EmpresaId))
				{
					_servicios.Borrar(em.EmpresaId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {em!.RazonSocial} del registro");
				}
				else
				{
					MessageHelper.Error($"{em.RazonSocial} esta relacionado con otros registros, eliminacion denegada");
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
			var em = r.Tag as Empresa;
			var dr = MessageHelper.Question($"Esta seguro de editar {em!.RazonSocial}?");
			if (dr == DialogResult.No) return;
			try
			{
				var frm = new frmEmpresasAE(_serviceProvider!) { Text = "Editando registro" };
				frm.Empresa = em!;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				em = frm.Empresa;
				if (!_servicios!.Existe(em))
				{
					_servicios.Guardar(em);
					GridHelper.SetFila(r, em);
					MessageHelper.Information($"Se ha editado {em!.RazonSocial} del registro");
				}
				else
				{
					MessageHelper.Error($"{em.RazonSocial} ya existe en los registros");
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
			cbxOrdenar.SelectedIndex = 0;
			tbxFiltroTexto.Clear();
		}

		private void frmEmpresas_FormClosing(object sender, FormClosingEventArgs e)
		{
			var dr = MessageHelper.Question("Esta seguro de cerrar la aplciacion?");
			if (dr == DialogResult.No) e.Cancel = true;
		}

		private void btnFiltrar_Click(object sender, EventArgs e)
		{
			textoFiltro = tbxFiltroTexto.Text;
			RecargarGrilla(orden, textoFiltro);
		}

		private void btnQuitarOrden_Click(object sender, EventArgs e)
		{
			RecargarGrilla(OrdenarEmpresas.Ninguno, textoFiltro);
		}

		private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
		{
			orden = cbxOrdenar.SelectedIndex > 0 ? (OrdenarEmpresas)cbxOrdenar.SelectedItem!
												 : OrdenarEmpresas.Ninguno;
			btnQuitarOrden.Enabled = true;
			RecargarGrilla(orden, textoFiltro);
		}
	}
}
