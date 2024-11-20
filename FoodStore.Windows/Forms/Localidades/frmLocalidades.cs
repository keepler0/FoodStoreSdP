using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Forms.Provincias;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Localidades
{
	public partial class frmLocalidades : Form
	{
		private readonly IServiciosLocalidades? _servicios;
		private List<LocalidadListDto>? lista;
		private IServiceProvider? _serviceProvider;
		private Pais? paisSeleccionado = null;
		private Provincia? provinciaSeleccionada = null;
		private OrdenarLocalidades? ordenar = OrdenarLocalidades.Ninguno;
		public frmLocalidades(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosLocalidades>();
		}
		private void frmLocalidades_Load(object sender, EventArgs e)
		{
			CombosHelper.CargarCombosPaises(ref cbxPais, _serviceProvider);
			CombosHelper.CargarCombosOrden(ref cbxOrdenar, ordenar);
			RecargarGrilla();
		}
		private void RecargarGrilla(OrdenarLocalidades? ordenar = OrdenarLocalidades.Ninguno,
									Pais? pais = null,
									Provincia? provincia = null)//Tambien tener en cuenta traer por Provincia
		{
			lista = _servicios!.GetLista(ordenar, pais, provincia);
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
			var frm = new frmLocalidadesAE(_serviceProvider!) { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var localidad = frm.Localidad!;
				LocalidadListDto lDto = localidad;
				if (!_servicios!.Existe(localidad!))
				{
					_servicios.Guardar(localidad!);

					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, lDto!);
					GridHelper.AgregarFila(dgvDatos, r);
					MessageHelper.Information("Registro agregado correctamente");
					CombosHelper.CargarCombosPaises(ref cbxPais, _serviceProvider);
					//recargar el combo provincias
				}
				else
				{
					MessageHelper.Error($"{lDto.NombreCompleto} ya existe en el registro");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}
		private void btnBorrar_Click(object sender, EventArgs e)
		{
			//Continuar
			if (dgvDatos.SelectedRows.Count == 0) return;
			var r = dgvDatos.SelectedRows[0];
			var lDto = r.Tag as LocalidadListDto;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {lDto!.NombreCompleto} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(lDto.LocalidadId))
				{
					_servicios.Borrar(lDto.LocalidadId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {lDto!.NombreCompleto} del registro");
				}
				else
				{
					MessageHelper.Error($"{lDto.NombreCompleto} esta relacionado con otros registros, eliminacion denegada");
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
			var lDto = r.Tag as LocalidadListDto;
			var dr = MessageHelper.Question($"Esta seguro de editar {lDto!.NombreCompleto}?");
			if (dr == DialogResult.No) return;
			try
			{
				var frm = new frmLocalidadesAE(_serviceProvider!) { Text = "Editando registro" };
				Localidad localidad = _servicios!.GetItem(lDto.LocalidadId)!;
				frm.Localidad = localidad;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				localidad = frm.Localidad;
				lDto = localidad;
				if (!_servicios!.Existe(localidad))
				{
					_servicios.Guardar(localidad);
					GridHelper.SetFila(r, lDto);
					MessageHelper.Information($"Se ha editado {lDto!.NombreCompleto} del registro");
				}
				else
				{
					MessageHelper.Error($"{lDto.NombreCompleto} ya existe en los registros");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}

		}
		private void btnQuitarFiltro_Click(object sender, EventArgs e)
		{
			cbxPais.SelectedIndex = 0;
			btnQuitarFiltro.Enabled = false;

		}

		private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e)
		{
			//TODO: verificar ya que no trae la lista filtrada por provincia
			if (paisSeleccionado is not null)
			{
				provinciaSeleccionada = cbxProvincia.SelectedIndex > 0 ?
												   cbxProvincia.SelectedItem as Provincia : null;
				RecargarGrilla(ordenar, paisSeleccionado, provinciaSeleccionada);
				btnQuitarProvincia.Enabled = true; 
			}

		}

		private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
		{
			paisSeleccionado = cbxPais.SelectedIndex > 0 ?
							   cbxPais.SelectedItem as Pais : null;
			
			if (paisSeleccionado is not null)
			{
				RecargarGrilla(ordenar, paisSeleccionado, provinciaSeleccionada);
				CombosHelper.CargarCombosProvincias(ref cbxProvincia, 
														_serviceProvider!, 
														paisSeleccionado);
			}
			btnQuitarFiltro.Enabled = true;

		}

		private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
		{
			ordenar = cbxOrdenar.SelectedItem as OrdenarLocalidades?;
			if (ordenar!=OrdenarLocalidades.Ninguno)
			{
				RecargarGrilla(ordenar, paisSeleccionado, provinciaSeleccionada);
				btnQuitarOrden.Enabled = true;
			}
		}

		private void btnQuitarProvincia_Click(object sender, EventArgs e)
		{
			cbxProvincia.SelectedIndex = 0;
			btnQuitarProvincia.Enabled = false;

		}

		private void btnQuitarOrden_Click(object sender, EventArgs e)
		{
			cbxOrdenar.SelectedIndex = 0;
			btnQuitarOrden.Enabled = false;
			RecargarGrilla(OrdenarLocalidades.Ninguno);
		}
	}
}
