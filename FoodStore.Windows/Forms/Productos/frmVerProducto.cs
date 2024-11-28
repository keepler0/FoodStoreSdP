using FoodStore.Entidades;

namespace FoodStore.Windows.Forms.Productos
{
	public partial class frmVerProducto : Form
	{
		private Producto? _producto;
		private static string rutaProyecto=AppDomain.CurrentDomain.BaseDirectory;
		private string rutaCarpeta = Path.Combine(rutaProyecto, "Imagenes");
		public Producto? Producto
		{
			get { return _producto; }
			set { _producto = value; }
		}

		public frmVerProducto()
		{
			InitializeComponent();
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmVerProducto_Load(object sender, EventArgs e)
		{
			if (_producto is not null)
			{
				lblMarca.Text = _producto.Marca;
				lblDescripcion.Text = _producto.Descripcion;
				lblCategoria.Text = _producto.Categoria?.NombreCategoria ?? "N/D";
				lblSubCategoria.Text = _producto.SubCategoria?.NombreSubCategoria ?? "N/D";
				lblStock.Text = _producto.Stock.ToString();
				lblStockMinimo.Text = _producto.StockMinimo.ToString();
				lblPrecioUnitario.Text = _producto.PrecioUnitario.ToString();
				lblPrecioFinal.Text = _producto?.PrecioFinal.ToString();
				if (_producto?.Imagen is not null)
				{
					var rutaImagen = Path.Combine(rutaCarpeta, "Imagenes");
					if (Directory.Exists(rutaImagen)) 
					{ 
						
					}
				}
			}
		}
	}
}
