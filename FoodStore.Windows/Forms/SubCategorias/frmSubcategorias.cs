using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Forms.SubCategorias;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.SubCategorias
{
	public partial class frmSubcategorias : Form
	{
		private readonly IServiceProvider? _serviceProvider;
		private readonly IServiciosSubCategorias? _servicios;
		private List<SubCategoriaListDto>? lista;
		private OrdenarCategorias? ordenar = OrdenarCategorias.Ninguno;
		private Categoria? categoria = null;
		public frmSubcategorias(IServiceProvider? serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider!.GetService<IServiciosSubCategorias>();

		}

		private void frmSubcategorias_Load(object sender, EventArgs e)
		{
			RecargarGrilla();
			lista = _servicios!.GetLista();
			CombosHelper.CargarCombosCategorias(ref cbxCombosCategorias, _serviceProvider!);
			CombosHelper.CargarCombosOrden(ref cbxOrdenar, ordenar);
		}
		private void RecargarGrilla(OrdenarCategorias? ordenar = OrdenarCategorias.Ninguno,
									Categoria? c = null)
		{
			lista = _servicios!.GetLista(ordenar, c);
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
			var frm = new frmSubCategoriasAE(_serviceProvider!) { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var Subcategoria = frm.SubCategoria;
				SubCategoriaListDto scDto = Subcategoria!;
				if (!_servicios!.Existe(Subcategoria!))
				{
					_servicios.Guardar(Subcategoria!);
					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, scDto!);
					GridHelper.AgregarFila(dgvDatos, r);
					MessageHelper.Information("Registro agregado correctamente");
				}
				else
				{
					MessageHelper.Error($"{scDto!.NombreSubCategoria} ya existe en los registros");

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
			var scDto = r.Tag as SubCategoriaListDto;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {scDto!.NombreSubCategoria} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(scDto.SubCategoriaId))
				{
					_servicios.Borrar(scDto.SubCategoriaId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {scDto.NombreSubCategoria} del registro");
				}
				else
				{
					MessageHelper.Error($"{scDto.NombreSubCategoria} esta relacionado con otros registros, eliminacion denegada");
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
			var scDto = r.Tag as SubCategoriaListDto;
			var dr = MessageHelper.Question($"Esta seguro de editar {scDto!.NombreSubCategoria}?");
			if (dr == DialogResult.No) return;
			var sc = _servicios!.GetItem(scDto!.SubCategoriaId);
			try
			{
				var frm = new frmSubCategoriasAE(_serviceProvider!);
				frm.SubCategoria = sc;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				sc = frm.SubCategoria;
				scDto = sc!;
				if (!_servicios!.Existe(sc!))
				{
					_servicios.Guardar(sc!);

					GridHelper.SetFila(r, scDto);
					MessageHelper.Information($"Se ha editado {scDto!.NombreSubCategoria} del registro");
				}
				else
				{
					MessageHelper.Error($"{scDto!.NombreSubCategoria} ya existe en los registros");
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

		private void frmSubcategorias_FormClosing(object sender, FormClosingEventArgs e)
		{
			var dr = MessageHelper.Question("Esta seguro de cerrar la aplcicacion?");
			if (dr == DialogResult.Cancel) e.Cancel = true;
		}

		private void cbxCombosCategorias_SelectedIndexChanged(object sender, EventArgs e)
		{
			categoria = cbxCombosCategorias.SelectedIndex > 0 ?
						cbxCombosCategorias.SelectedItem as Categoria :
						null;
			RecargarGrilla(ordenar, categoria);
			btnQuitarFiltro.Enabled = true;
		}

		private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
		{
			ordenar = cbxOrdenar.SelectedIndex > 0 ?
					 (OrdenarCategorias)cbxOrdenar.SelectedItem! : null;
			RecargarGrilla(ordenar, categoria);
			btnQuitarOrden.Enabled = true;
		}

		private void btnQuitarOrden_Click(object sender, EventArgs e)
		{
			RecargarGrilla(null, categoria);
			btnQuitarOrden.Enabled = false;
		}

		private void btnQuitarFiltro_Click(object sender, EventArgs e)
		{
			RecargarGrilla(ordenar, null);
			btnQuitarFiltro.Enabled = false;
		}
	}
}
