using FoodStore.Datos.Interfaces;
using FoodStore.Datos.Repositorios;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Entidades;
using System.Data.SqlClient;
using FoodStore.Servicios.Interfaces;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosProductos:IServiciosProductos
	{
		private readonly IRepositorioProductos? _repositorio;
		private readonly string? CadenaConexion;
		public ServiciosProductos(RepositorioProductos? repositorio, string cadena)
		{
			CadenaConexion = cadena;
			_repositorio = repositorio;
		}
		public void Borrar(int id)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						_repositorio!.Borrar(id, conexion, tran);
						tran.Commit();
					}
					catch (Exception)
					{
						tran.Rollback();
						throw;
					}
				}
			}
		}

		public bool EstaRelacionado(int id)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.EstaRelacionado(id, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public bool Existe(Producto? producto)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.Existe(producto, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public Producto? GetItem(int id)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.GetItem(id, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public List<ProductoListDto>? GetLista(string? filtroMarca = null,
									OrdenarProductos? ordenar = OrdenarProductos.Ninguno,
									Categoria? categoria = null,
									SubCategoria? subCategoria = null)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.GetLista(conexion, null, filtroMarca, ordenar, categoria,subCategoria);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public void Guardar(Producto? producto)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (producto!.ProductoId == 0)
						{
							_repositorio!.Agregar(producto, conexion, tran);
						}
						else
						{
							_repositorio!.Editar(producto, conexion, tran);
						}
						tran.Commit();
					}
					catch (Exception)
					{
						tran.Rollback();
						throw;
					}
				}
			}
		}
	}
}
