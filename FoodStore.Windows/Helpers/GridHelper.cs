using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;

namespace FoodStore.Windows.Helpers
{
	public static class GridHelper
	{
		public static DataGridViewRow ConstruirFila(DataGridView dgvDatos)
		{
			var r = new DataGridViewRow();
			r.CreateCells(dgvDatos);
			return r;
		}
		public static void SetFila(DataGridViewRow r, object obj)
		{
			switch (obj)
			{
				case Pais p:
					r.Cells[0].Value = p.NombrePais;
					break;
				case Categoria c:
					r.Cells[0].Value = c.NombreCategoria;
					break;
				case ProvinciaListDto pe:
					r.Cells[0].Value = pe.NombrePais;
					r.Cells[1].Value = pe.NombreProvincia;
					break;
				case SubCategoriaListDto sc:
					r.Cells[0].Value = sc.NombreCategoria;
					r.Cells[1].Value = sc.NombreSubCategoria;
					break;
				case LocalidadListDto lDto:
					r.Cells[0].Value = lDto.NombrePais;
					r.Cells[1].Value = lDto.NombreProvincia;
					r.Cells[2].Value = lDto.NombreLocalidad;
					break;
				
				case EmpleadoListDto e:
					r.Cells[0].Value = e.Nombre;
					r.Cells[1].Value = e.Apellido;
					r.Cells[2].Value = e.Cuit;
					r.Cells[3].Value = e.NombreRol;
					r.Cells[4].Value = e.Activo;
					break;
				case Empresa em:
					r.Cells[0].Value = em.RazonSocial;
					r.Cells[1].Value = em.Direccion ?? "N/D";
					r.Cells[2].Value = em.Cuit ?? "N/D";
					r.Cells[3].Value = em.Telefono ?? "N/D";
					r.Cells[4].Value = em.Email ?? "N/D";
					break;
				case ClienteListDto cl:
					r.Cells[0].Value = cl.NombreCompleto;
					r.Cells[1].Value = cl.DireccionCompleta ?? "N/D";
					r.Cells[2].Value = cl.Telefono ?? "N/D";
					break;
				case ProductoListDto p:
					r.Cells[0].Value = p.Marca;
					r.Cells[1].Value = p.Descripcion ?? "N/D";
					r.Cells[2].Value = p.NombreCategoria ?? "N/D";
					r.Cells[3].Value = p.NombreSubCategoria ?? "N/D";
					r.Cells[4].Value = p.Stock.ToString() ?? "N/D";
					r.Cells[5].Value = p.PrecioUnitario.ToString() ?? "N/D";
					r.Cells[6].Value = p.PrecioFinal.ToString() ?? "N/D";
					r.Cells[7].Value = p.FechaVencimiento.HasValue?p.FechaVencimiento.Value.ToShortDateString(): "N/D";
					break;
				case ComboListDto c:
					r.Cells[0].Value = c.NombreCombo;
					r.Cells[1].Value = c.Descripcion ?? "N/D";
					r.Cells[2].Value = c.NombreTamanio ?? "N/D";
					r.Cells[3].Value = c.CantidadProductos;
					r.Cells[4].Value = c.PrecioCombo;
					r.Cells[5].Value = c.Vigente;
					break;
				case ComboProducto cp:
					r.Cells[0].Value = cp.Producto!.ProductoId;
					r.Cells[1].Value = cp.Producto!.CodigoBarras;
					r.Cells[2].Value = cp.Producto!.Descripcion ?? "N/D";
					r.Cells[3].Value = cp.Cantidad.ToString() ?? "N/D";
					break;
				default:
					break;
			}
			r.Tag= obj;
		}
		public static void AgregarFila(DataGridView dgvDatos, DataGridViewRow r)
		{
			dgvDatos.Rows.Add(r);
		}
		public static void EliminarFila(DataGridView dgvDatos, DataGridViewRow r)
		{
			dgvDatos.Rows.Remove(r);
		}
		public static void LimpiarGrilla(DataGridView dgvDatos)
		{
			dgvDatos.Rows.Clear();
		}

		public static void MostrarDatosEnGrilla<T>(List<T>? lista,DataGridView dgvDatos)where T : class
		{
			LimpiarGrilla(dgvDatos);
			foreach (var item in lista!)
			{
				var r = ConstruirFila(dgvDatos);
				SetFila(r, dgvDatos);
				AgregarFila(dgvDatos, r);
			}
		}
	}
}
