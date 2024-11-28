using FoodStore.Entidades.Dtos;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Forms.Combos
{
	public partial class frmCombos : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IServiciosCombos _servicios;
		private List<ComboListDto>? lista;
		public frmCombos(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosCombos>()!;
		}

		private void frmCombos_Load(object sender, EventArgs e)
		{
			lista = _servicios.GetLista();
			GridHelper.MostrarDatosEnGrilla(lista, dgvDatos);
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			var frm = new frmCombosAE(_serviceProvider);
			var dr = frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			var combo = frm.Combo;
			if (combo is null) return;
			try
			{
				GridHelper.MostrarDatosEnGrilla(lista, dgvDatos);
				MessageHelper.Information("Registro agregado!");
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
