using FoodStore.Datos.Interfaces;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Entidades;
using System.Data.SqlClient;
using Dapper;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioProductos : IRepositorioProductos
	{
		public void Agregar(Producto? producto, SqlConnection? conexion, SqlTransaction? tran)
		{
			string InsertQuery = @"INSERT INTO Inventario(Marca,Descripcion,Stock,StockMinimo,
														CategoriaId,SubCategoriaId,
														PrecioFinal,PrecioUnitario,FechaVencimiento
														,Imagen,CodigoBarras)
									VALUES(@Marca,@Descripcion,@Stock,@StockMinimo,
														@CategoriaId,@SubCategoriaId,
														@PrecioFinal,@PrecioUnitario,@FechaVencimiento
														,@Imagen,@CodigoBarras);
									SELECT SCOPE_IDENTITY()";
			int id = conexion!.QuerySingle<int>(InsertQuery, producto, tran);
			if (id == 0) throw new Exception("No ha sido posible agregar el registro");
			producto!.ProductoId = id;
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM Inventario WHERE ProductoId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("No ha sido posible agregar el registro");
		}

		public void Editar(Producto? producto, SqlConnection? conexion, SqlTransaction? tran)
		{
			string UpdateQuery = @"UPDATE Inventario SET 
										Marca=@Marca,Descripcion=@Descripcion,
										Stock=@Stock,StockMinimo=@StockMinimo,
										CategoriaId=@CategoriaId,
										SubCategoriaId=@SubCategoriaId,
										PrecioFinal=@PrecioFinal,
										PrecioUnitario=@PrecioUnitario,
										FechaVencimiento=@FechaVencimiento,
										Imagen=@Imagen
								 WHERE ProductoId=@ProductoId";
			int rows = conexion!.Execute(UpdateQuery, producto, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM CombosProductos 
								   WHERE ProductoId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Producto? producto, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Inventario 
								   WHERE CodigoBarras=@CodigoBarras";
			if (producto!.ProductoId != 0)
			{
				SelectQuery += " AND ProductoId<>@ProductoId";
			}
			return conexion.QuerySingle<int>(SelectQuery, producto) > 0;
		}

		public Producto? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT ProductoId,Marca,Descripcion,Stock,StockMinimo,
										  CategoriaId,SubCategoriaId,
										  PrecioFinal,PrecioUnitario,FechaVencimiento,Imagen,CodigoBarras
										FROM Inventario 
										WHERE ProductoId=@id";
			return conexion.QuerySingle<Producto?>(SelectQuery, new { id });
		}

		public List<ProductoListDto>? GetLista(SqlConnection conexion,
											 SqlTransaction? tran = null,
											 string? filtroMarca = null,
											 OrdenarProductos? ordenar = OrdenarProductos.Ninguno,
											 Categoria? categoria = null,
											 SubCategoria? subCategoria = null)
		{
			string SelectQuery = @"SELECT i.ProductoId,i.Marca,i.Descripcion,i.Stock,
								   c.NombreCategoria,sc.NombreSubCategoria,i.PrecioUnitario,
									i.PrecioFinal,i.FechaVencimiento
									FROM Inventario i
									INNER JOIN Categorias c ON i.CategoriaId=c.CategoriaId
									INNER JOIN SubCategorias sc ON i.SubCategoriaId=sc.SubCategoriaId";
			if (!string.IsNullOrEmpty(filtroMarca) &&
				categoria is not null && 
				subCategoria is not null)
			{
				SelectQuery += @$" WHERE i.Marca LIKE '%{filtroMarca}%' 
								   AND i.CategoriaId= {categoria.CategoriaId}
									AND i.SubCategoriaId= {subCategoria.SubCategoriaId}";
			}
			else if (!string.IsNullOrEmpty(filtroMarca) &&
					 categoria is not null)
			{
				SelectQuery += @$" WHERE i.Marca LIKE '%{filtroMarca}%' 
								   AND i.CategoriaId= {categoria.CategoriaId}";
			}
			else if (categoria is not null &&
				     subCategoria is not null)
			{
				SelectQuery += @$" WHERE i.CategoriaId= {categoria.CategoriaId} 
								   AND i.SubCategoriaId= {subCategoria.SubCategoriaId}";
			}
			else if (!string.IsNullOrEmpty(filtroMarca))
			{
				SelectQuery += @$" WHERE i.Marca LIKE '%{filtroMarca}%'";
			}
			else if (categoria is not null)
			{
				SelectQuery += @$" WHERE i.CategoriaId= {categoria.CategoriaId}";
			}
			else if (subCategoria is not null)
			{
				SelectQuery += @$" WHERE i.SubCategoriaId= {subCategoria.SubCategoriaId}";

			}
			switch (ordenar)
			{
				case OrdenarProductos.Ninguno:
					break;
				case OrdenarProductos.MarcaAZ:
					SelectQuery += " ORDER BY i.Marca";
					break;
				case OrdenarProductos.MarcaZA:
					SelectQuery += " ORDER BY i.Marca DESC";
					break;
				case OrdenarProductos.CategoriaAZ:
					SelectQuery += " ORDER BY c.NombreCategoria";
					break;
				case OrdenarProductos.CategoriaZA:
					SelectQuery += " ORDER BY c.NombreCategoria DESC";
					break;
				case OrdenarProductos.SubCategoriaAZ:
					SelectQuery += " ORDER BY sc.NombreSubCategoria";
					break;
				case OrdenarProductos.SubCategoriaZA:
					SelectQuery += " ORDER BY sc.NombreSubCategoria DESC";
					break;
				case OrdenarProductos.Stock:
					SelectQuery += " ORDER BY i.Stock";
					break;
				case OrdenarProductos.StockDESC:
					SelectQuery += " ORDER BY i.Stock DESC";
					break;
				case OrdenarProductos.PrecioUnitario:
					SelectQuery += " ORDER BY i.PrecioUnitario";
					break;
				case OrdenarProductos.PrecioUnitarioDESC:
					SelectQuery += " ORDER BY i.PrecioUnitario DESC";
					break;
				case OrdenarProductos.PrecioFinal:
					SelectQuery += " ORDER BY i.PrecioFinal";
					break;
				case OrdenarProductos.PrecioFinalDESC:
					SelectQuery += " ORDER BY i.PrecioFinal DESC";
					break;
				case OrdenarProductos.FechaVencimiento:
					SelectQuery += " ORDER BY i.FechaVencimiento";
					break;
				case OrdenarProductos.FechaVencimientoDESC:
					SelectQuery += " ORDER BY i.FechaVencimiento DESC";
					break;
			}
			return conexion.Query<ProductoListDto>(SelectQuery).ToList();
		}

		public List<Producto> GetListaPorCategoria(SqlConnection conexion, int categoriaId)
		{
			string SelectQuery = @"SELECT ProductoId,Marca,Descripcion,Stock,StockMinimo,
										  CategoriaId,SubCategoriaId,
										  PrecioFinal,PrecioUnitario,FechaVencimiento,Imagen,CodigoBarras
										FROM Inventario 
										WHERE CategoriaId=@categoriaId";
			return conexion.Query<Producto>(SelectQuery, new { categoriaId }).ToList();
		}

		public List<Producto>? GetListaProductos(SqlConnection conexion)
		{
			string SelectQuery = @"SELECT ProductoId,Marca,Descripcion,Stock,StockMinimo,
										  CategoriaId,SubCategoriaId,
										  PrecioFinal,PrecioUnitario,FechaVencimiento,Imagen,CodigoBarras
										  FROM Inventario
										  ORDER BY CategoriaId,SubCategoriaId";
			return conexion.Query<Producto>(SelectQuery).ToList();
		}
	}
}
