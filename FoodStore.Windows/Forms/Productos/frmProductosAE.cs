using FoodStore.Entidades;
using FoodStore.Windows.Helpers;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace FoodStore.Windows.Forms.Productos
{
	public partial class frmProductosAE : Form
	{
		private IServiceProvider serviceProvider;
		private Producto? _producto;
		private Categoria? _categoria;
		private SubCategoria? _subCategoria;

		private string? imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\SinImagenDisponible.png";
		private string? archivoNoEncontrado = Environment.CurrentDirectory + @"\Imagenes\ArchivoNoEncontrado.png";
		private string? archivoImagen = string.Empty;
		private string carpetaImagen = Environment.CurrentDirectory + @"\ImagenesProductos\";
		public Producto? Producto
		{
			get { return _producto; }
			set { _producto = value; }
		}

		public frmProductosAE(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			this.serviceProvider = serviceProvider;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarCombosCategorias(ref cbxCategoria, serviceProvider);
			if (_producto is not null)
			{
				tbxMarca.Text = _producto.Marca;
				tbxDescripcion.Text = _producto.Descripcion;
				tbxStock.Text = _producto.Stock.ToString();
				tbxStockMin.Text = _producto.StockMinimo.ToString();
				tbxPrecioUnitario.Text = _producto.PrecioUnitario.ToString();
				tbxPrecioFinal.Text = _producto.PrecioFinal.ToString();
				cbxCategoria.SelectedValue = _producto.CategoriaId;
				cbxSubCategoria.SelectedValue = _producto.SubCategoriaId;
				dateTimePicker.Value = _producto.FechaVencimiento ?? DateTime.Now;
				tbxCodigo.Text = _producto.CodigoBarras;
				if (string.IsNullOrEmpty(_producto.Imagen))
				{
					picImagen.Image = Image.FromFile(imagenNoDisponible!);
				}
				else
				{
					if (File.Exists($"{carpetaImagen}{_producto.Imagen}"))
					{
						picImagen.Image = Image.FromFile($"{carpetaImagen}{_producto.Imagen}");
					}
					else
					{
						picImagen.Image = Image.FromFile(archivoNoEncontrado!);
					}
				}
			}
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void cbxSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			_subCategoria = cbxSubCategoria.SelectedIndex > 0 ? cbxSubCategoria.SelectedItem as SubCategoria : null;
		}

		private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			_categoria = cbxCategoria.SelectedIndex > 0 ?
						 cbxCategoria.SelectedItem as Categoria : null;
			if (_categoria is not null) CombosHelper.CargarCombosSubCategorias(ref cbxSubCategoria,
																			   serviceProvider,
																			   _categoria);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (Validar())
			{
				if (_producto is null)
				{
					_producto = new Producto();
				}
				_producto.Marca = tbxMarca.Text;
				_producto.Descripcion= tbxDescripcion.Text;
				_producto.Categoria = _categoria;
				_producto.CategoriaId = _categoria?.CategoriaId??0;
				_producto.SubCategoria=_subCategoria;
				_producto.SubCategoriaId = _subCategoria?.SubCategoriaId??0;
				_producto.Stock = int.Parse(tbxStock.Text);
				_producto.StockMinimo = int.Parse(tbxStockMin.Text);
				_producto.PrecioUnitario = decimal.Parse(tbxPrecioUnitario.Text);
				_producto.PrecioFinal = decimal.Parse(tbxPrecioFinal.Text);
				_producto.FechaVencimiento = dateTimePicker.Value;
				_producto.CodigoBarras = tbxCodigo.Text;
				_producto.Imagen = archivoImagen;
				DialogResult = DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(tbxMarca.Text))
			{
				MessageHelper.Error("Debe introducir alguna marca del producto");
				return false;
			}
			if (string.IsNullOrEmpty(tbxCodigo.Text))
			{
				MessageHelper.Error("Debe introducir algun codigo del producto");
				return false;
			}
			if (!int.TryParse(tbxStock.Text, out int stockMin) && stockMin < 0)
			{
				MessageHelper.Error("El stock minimo debe ser un valor numerico y mayor a cero");
				return false;
			}
			if (!int.TryParse(tbxStock.Text,out int stock) && stock<=stockMin)
			{
				MessageHelper.Error("El stock debe ser un valor numerico y mayor al stock minimo");
				return false;
			}
			if (!decimal.TryParse(tbxPrecioUnitario.Text, out decimal precioUnitario) && precioUnitario < 0)
			{
				MessageHelper.Error("El precio unitario debe ser un valor numerico y mayor a cero");
				return false;
			}
			if (!decimal.TryParse(tbxPrecioFinal.Text, out decimal precioFinal) && precioFinal <=precioUnitario)
			{
				MessageHelper.Error("El precio final debe ser un valor numerico y mayor a precio unitario");
				return false;
			}
			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.Multiselect = false;
			openFileDialog1.InitialDirectory=Environment.CurrentDirectory+@"\ImagenesProductos\";
			openFileDialog1.Filter = "Archivos png (*.png)|*.png|Archivos jpg (*.jpg)|*.jpg|Archivos jpeg (*.jpeg)|*.jpeg";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;
			var dr=openFileDialog1.ShowDialog(this);
			if (dr == DialogResult.OK)
			{
				if (openFileDialog1.FileName is null) return;
				picImagen.Image = Image.FromFile(openFileDialog1.FileName);
				archivoImagen = openFileDialog1.FileName;
			}
		}
	}
}
