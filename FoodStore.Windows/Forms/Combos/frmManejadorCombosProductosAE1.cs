using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using FoodStore.Windows.UsersControls;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices.Marshalling;

namespace FoodStore.Windows.Forms.Combos
{
	public partial class frmManejadorCombosProductosAE1 : Form
	{
		private readonly IServiceProvider? _serviceProvider;
		private readonly IServiciosProductos? _servicios;
		private List<Producto>? productos;
		private ComboProducto? _comboProducto;


		public ComboProducto? ComboProducto
		{
			get { return _comboProducto; }
			set { _comboProducto = value; }
		}
		public frmManejadorCombosProductosAE1(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_servicios = _serviceProvider.GetService<IServiciosProductos>()!;
		}

		private void frmManejadorCombosProductosAE_Load(object sender, EventArgs e)
		{
			RecargarGrilla();
		}

		private void RecargarGrilla()
		{
			productos = _servicios!.GetListaProductos();
			flowLayoutPanel1.Controls.Clear();
			foreach (var item in productos!)
			{
				var ucProducto = new ucProducto();
				SetUcControl(ucProducto,item);
				AgregarUcControl(ucProducto);
			}
		}

		private void AgregarUcControl(ucProducto ucProducto)
		{
			flowLayoutPanel1.Controls.Add(ucProducto);
		}

		private void SetUcControl(ucProducto ucProducto, Producto item)
		{
			ucProducto.ProductoId = item.ProductoId;
			ucProducto.NombreProducto = item.Descripcion!;
			ucProducto.PrecioProducto = item.PrecioFinal;
			//ucProducto.ImagenProducto = item.Imagen;
			//ucProducto.lblAgregar.Click += ;
		}
	}
}
