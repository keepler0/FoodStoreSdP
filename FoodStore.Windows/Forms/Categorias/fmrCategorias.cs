using FoodStore.Entidades;
using FoodStore.Servicios.Servicios;
using FoodStore.Windows.Forms.Paises;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Categorias
{
	public partial class fmrCategorias : Form
	{
		private IServiceProvider? _serviceProvider;
		private List<Categoria>? lista;
		private IServiciosCategorias? _servicios;

		public fmrCategorias(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosCategorias>();
		}

		private void fmrCategorias_Load(object sender, EventArgs e)
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
			var frm = new frmCategoriasAE() { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var categoria = frm.Categoria;
				if (!_servicios!.Existe(categoria!))
				{
					_servicios.Guardar(categoria!);
					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, categoria!);
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
			Categoria? c = r.Tag as Categoria;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {c!.NombreCategoria} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(c.CategoriaId))
				{
					_servicios.Borrar(c.CategoriaId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {c.NombreCategoria} del registro");
				}
				else
				{
					MessageHelper.Error($"{c.NombreCategoria} esta relacionado con otros registros, eliminacion denegada");
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
			Categoria? c = r.Tag as Categoria;
			var dr = MessageHelper.Question($"Esta seguro de editar {c!.NombreCategoria}?");
			if (dr == DialogResult.No) return;
			try
			{
				var frm = new frmCategoriasAE();
				frm.Categoria = c;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				c = frm.Categoria;
				if (!_servicios!.Existe(c))
				{
					_servicios.Guardar(c);
					GridHelper.SetFila(r, c);
					MessageHelper.Information($"Se ha editado {c!.NombreCategoria} del registro");
				}
				else
				{
					MessageHelper.Error($"{c!.NombreCategoria} ya existe en los registros");
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

		private void fmrCategorias_FormClosing(object sender, FormClosingEventArgs e)
		{
			var dr = MessageHelper.Question("Esta seguro de cerrar el registro de categorias?");
			if (dr == DialogResult.No) e.Cancel = true;
		}
	}
}
