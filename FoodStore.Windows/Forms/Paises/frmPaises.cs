using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Paises
{
	public partial class frmPaises : Form
	{
		private readonly IServiceProvider? _serviceProvider;
		private List<Pais>? lista;
		private readonly IServiciosPaises? _servicios;
		public frmPaises(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosPaises>();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPaises_Load(object sender, EventArgs e)
		{
			lista = _servicios!.GetLista();
			GridHelper.LimpiarGrilla(dgvDatos);
			foreach (var item in lista)
			{
				var r = GridHelper.ConstruirFila(dgvDatos);
				GridHelper.SetFila(r, item);
				GridHelper.AgregarFila(dgvDatos, r);
			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			var frm = new frmPaisesAE() { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var pais = frm.Pais;
				if (!_servicios!.Existe(pais!))
				{
					_servicios.Guardar(pais!);
					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, pais!);
					GridHelper.AgregarFila(dgvDatos, r);
					MessageHelper.Information("Registro agregado correctamente");
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
			Pais? pais = r.Tag as Pais;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {pais!.NombrePais} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(pais.PaisId))
				{
					_servicios.Borrar(pais.PaisId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {pais!.NombrePais} del registro");
				}
				else
				{
					MessageHelper.Error($"{pais.NombrePais} esta relacionado con otros registros, eliminacion denegada");
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
			Pais? pais = r.Tag as Pais;
			var dr = MessageHelper.Question($"Esta seguro de editar {pais!.NombrePais}?");
			if (dr == DialogResult.No) return;
			try
			{
				var frm = new frmPaisesAE();
				frm.Pais = pais;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				pais = frm.Pais;
				if (!_servicios!.Existe(pais))
				{
					_servicios.Guardar(pais);
					GridHelper.SetFila(r, pais);
					MessageHelper.Information($"Se ha editado {pais!.NombrePais} del registro");
				}
				else
				{
					MessageHelper.Error($"{pais.NombrePais} ya existe en los registros");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}

		private void frmPaises_FormClosing(object sender, FormClosingEventArgs e)
		{
			var dr = MessageHelper.Question("Esta seguro de cerrar el registro de paises?");
			if (dr == DialogResult.No) e.Cancel = true;
		}
	}
}
