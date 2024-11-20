using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Productos
{
	public partial class frmProductos : Form
	{
		private IServiceProvider? _serviceProvider;
		private IServiciosProductos? _servicios;
		private List<ProductoListDto>? lista;
		private string? filtroMarca;
		private Categoria? categoriaSeleccionada;
		private SubCategoria? subCategoriaSeleccionada;
		private OrdenarProductos? ordenar = OrdenarProductos.Ninguno;
		public frmProductos(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosProductos>();
		}

		private void frmProductos_Load(object sender, EventArgs e)
		{
			CombosHelper.CargarCombosOrden(ref cbxOrdenar, ordenar);
			CombosHelper.CargarCombosCategorias(ref cbxCategorias, _serviceProvider!);
			RecargarGrilla();
		}

		private void RecargarGrilla(string? filtroMarca = null,
									OrdenarProductos? ordenar = OrdenarProductos.Ninguno,
									Categoria? categoria = null,
									SubCategoria? subCategoria = null)
		{
			lista = _servicios!.GetLista(filtroMarca, ordenar, categoria, subCategoria);
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

		private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxCategorias.SelectedIndex > 0)
			{
				categoriaSeleccionada = cbxCategorias.SelectedItem as Categoria;
				if (categoriaSeleccionada is not null)
				{
					CombosHelper.CargarCombosSubCategorias(ref cbxSubCategorias,
															_serviceProvider,
															categoriaSeleccionada);
					btnQuitarCategoria.Enabled = true;
					RecargarGrilla(filtroMarca, ordenar, categoriaSeleccionada, subCategoriaSeleccionada);

				}
			}
		}

		private void cbxSubCategorias_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxSubCategorias.SelectedIndex > 0)
			{
				subCategoriaSeleccionada = cbxSubCategorias.SelectedItem as SubCategoria;
				btnQuitarSubCategoria.Enabled = true;
				RecargarGrilla(filtroMarca, ordenar, categoriaSeleccionada, subCategoriaSeleccionada);

			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			var frm = new frmProductosAE(_serviceProvider!) { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var producto = frm.Producto!;
				ProductoListDto? productoDto = producto;
				if (!_servicios!.Existe(producto!))
				{
					_servicios.Guardar(producto!);

					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, productoDto!);
					GridHelper.AgregarFila(dgvDatos, r);
					MessageHelper.Information("Registro agregado correctamente");
				}
				else
				{
					MessageHelper.Error($"{productoDto.Descripcion} ya existe en el registro");
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
			var productoDto = r.Tag as ProductoListDto;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {productoDto!.Descripcion} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(productoDto.ProductoId))
				{
					_servicios.Borrar(productoDto.ProductoId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {productoDto!.Descripcion} del registro");
				}
				else
				{
					MessageHelper.Error($"{productoDto.Descripcion} esta relacionado con otros registros, eliminacion denegada");
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
			var productoDto = r.Tag as ProductoListDto;
			var dr = MessageHelper.Question($"Esta seguro de editar {productoDto!.Descripcion}?");
			if (dr == DialogResult.No) return;
			try
			{
				var frm = new frmProductosAE(_serviceProvider!) { Text = "Editando registro" };
				Producto? producto = _servicios!.GetItem(productoDto.ProductoId)!;
				frm.Producto = producto;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				producto = frm.Producto;
				productoDto = producto;
				if (!_servicios!.Existe(producto))
				{
					_servicios.Guardar(producto);
					GridHelper.SetFila(r, productoDto);
					MessageHelper.Information($"Se ha editado {productoDto!.Descripcion} del registro");
				}
				else
				{
					MessageHelper.Error($"{productoDto.Descripcion} ya existe en los registros");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}

		private void btnQuitarCategoria_Click(object sender, EventArgs e)
		{
			cbxCategorias.SelectedIndex = 0;
			categoriaSeleccionada = null;
			btnQuitarCategoria.Enabled = false;
			RecargarGrilla(filtroMarca, ordenar, categoriaSeleccionada, subCategoriaSeleccionada);
		}

		private void btnQuitarSubCategoria_Click(object sender, EventArgs e)
		{
			cbxSubCategorias.SelectedIndex = 0;
			subCategoriaSeleccionada = null;
			btnQuitarSubCategoria.Enabled = false;
			RecargarGrilla(filtroMarca, ordenar, categoriaSeleccionada, subCategoriaSeleccionada);
		}

		private void btnQuitarOrden_Click(object sender, EventArgs e)
		{
			cbxOrdenar.SelectedIndex = 0;
			ordenar = OrdenarProductos.Ninguno;
			btnQuitarOrden.Enabled = false;
			RecargarGrilla(filtroMarca, ordenar, categoriaSeleccionada, subCategoriaSeleccionada);
		}

		private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxOrdenar.SelectedIndex > 0)
			{
				ordenar = (OrdenarProductos)cbxOrdenar.SelectedItem!;
				RecargarGrilla(filtroMarca, ordenar, categoriaSeleccionada, subCategoriaSeleccionada);
				btnQuitarOrden.Enabled = true;
			}
		}

		private void btnBuscarMarca_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbxMarca.Text)) return;
			filtroMarca = tbxMarca.Text;
			RecargarGrilla(filtroMarca, ordenar, categoriaSeleccionada, subCategoriaSeleccionada);
		}

		private void btnActualiza_Click(object sender, EventArgs e)
		{
			cbxCategorias.SelectedIndex = 0;
			categoriaSeleccionada = null;
			if (cbxSubCategorias.Items.Count>0)
			{
				cbxSubCategorias.SelectedIndex = 0;
			}
			subCategoriaSeleccionada = null;
			cbxOrdenar.SelectedIndex = 0;
			ordenar = OrdenarProductos.Ninguno;
			tbxMarca.Clear();
			filtroMarca = null;
			btnQuitarCategoria.Enabled = false;
			btnQuitarSubCategoria.Enabled = false;
			btnQuitarOrden.Enabled = false;
			RecargarGrilla(filtroMarca, ordenar, categoriaSeleccionada, subCategoriaSeleccionada);

		}

		private void btnDatos_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) return;
			var r=dgvDatos.SelectedRows[0];
			var productoDto = r.Tag as ProductoListDto;
			var producto= _servicios!.GetItem(productoDto!.ProductoId);
			var frm = new frmVerProducto();
			frm.Producto= producto;
			frm.ShowDialog();
		}
	}
}
