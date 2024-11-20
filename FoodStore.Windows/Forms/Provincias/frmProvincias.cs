using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Provincias
{
	public partial class frmProvincias : Form
	{
		private readonly IServiciosProvincias? _servicios;
		private List<ProvinciaListDto>? lista;
		private IServiceProvider? _serviceProvider;
		private Pais? paisSeleccionado;
		private Ordenar? ordenar = Ordenar.Ninguno;
		public frmProvincias(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosProvincias>();
		}
		private void frmProvincias_Load(object sender, EventArgs e)
		{
			CombosHelper.CargarCombosPaises(ref cbxPais, _serviceProvider);
			CombosHelper.CargarCombosOrden(ref cbxOrdenar);
			RecargarGrilla();
		}

		private void RecargarGrilla(Ordenar? ordenar = Ordenar.Ninguno,
									Pais? pais = null)
		{
			lista = _servicios!.GetLista(ordenar, pais);
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
			var frm = new frmProvinciasAE(_serviceProvider!) { Text = "Agregando nuevo registro" };
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var provincia = frm.Provincia!;
				ProvinciaListDto peDto = provincia;
				if (!_servicios!.Existe(provincia!))
				{
					_servicios.Guardar(provincia!);

					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetFila(r, peDto!);
					GridHelper.AgregarFila(dgvDatos, r);
					MessageHelper.Information("Registro agregado correctamente");
					CombosHelper.CargarCombosPaises(ref cbxPais, _serviceProvider);
				}
				else
				{
					MessageHelper.Error($"{peDto.NombreCompleto} ya existe en el registro");
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
			var peDto = r.Tag as ProvinciaListDto;
			var dr = MessageHelper.Question($"Esta seguro de eliminar {peDto!.NombreCompleto} del registro?");
			if (dr == DialogResult.No) return;
			try
			{
				if (!_servicios!.EstaRelacionado(peDto.ProvinciaId))
				{
					_servicios.Borrar(peDto.ProvinciaId);
					GridHelper.EliminarFila(dgvDatos, r);
					MessageHelper.Information($"Se ha eliminado {peDto!.NombreCompleto} del registro");
				}
				else
				{
					MessageHelper.Error($"{peDto.NombreCompleto} esta relacionado con otros registros, eliminacion denegada");
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
			var peDto = r.Tag as ProvinciaListDto;
			var dr = MessageHelper.Question($"Esta seguro de editar {peDto!.NombreCompleto}?");
			if (dr == DialogResult.No) return;
			try
			{
				var frm = new frmProvinciasAE(_serviceProvider!) { Text = "Editando registro" };
				Provincia pr = _servicios!.GetItem(peDto.ProvinciaId)!;
				frm.Provincia = pr;
				dr = frm.ShowDialog();
				if (dr == DialogResult.Cancel) return;
				pr = frm.Provincia;
				peDto = pr;
				if (!_servicios!.Existe(pr))
				{
					_servicios.Guardar(pr);
					GridHelper.SetFila(r, peDto);
					MessageHelper.Information($"Se ha editado {peDto!.NombreCompleto} del registro");
				}
				else
				{
					MessageHelper.Error($"{peDto.NombreCompleto} ya existe en los registros");
				}
			}
			catch (Exception ex)
			{
				MessageHelper.Error(ex.Message);
			}
		}

		private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
		{
			paisSeleccionado = cbxPais.SelectedIndex != 0 ? cbxPais.SelectedItem as Pais : null;
			RecargarGrilla(ordenar, paisSeleccionado);
			btnQuitarFiltro.Enabled = true;
		}

		private void btnQuitarFiltro_Click(object sender, EventArgs e)
		{
			RecargarGrilla();
			cbxPais.SelectedIndex = 0;
			btnQuitarFiltro.Enabled = false;
		}

		private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
		{
			ordenar = cbxOrdenar.SelectedItem as Ordenar?;
			RecargarGrilla(ordenar, paisSeleccionado);
			btnQuitarOrden.Enabled = true;
		}

		private void btnQuitarOrden_Click(object sender, EventArgs e)
		{
			RecargarGrilla();
			cbxOrdenar.SelectedIndex = 0;
			btnQuitarOrden.Enabled = false;

		}

		private void btnActualiza_Click(object sender, EventArgs e)
		{
			RecargarGrilla();
			cbxPais.SelectedIndex = 0;
			cbxOrdenar.SelectedIndex = 0;

		}
	}
}
