using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosSubCategorias : IServiciosSubCategorias
	{
		private readonly IRepositorioSubCategorias _repositorio;
		private readonly string CadenaConexion = string.Empty;
		public ServiciosSubCategorias(IRepositorioSubCategorias repositorio, string cadena)
		{
			_repositorio = repositorio;
			CadenaConexion = cadena;

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
						_repositorio.Borrar(id, conexion, tran);
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
					return _repositorio.EstaRelacionado(id, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public bool Existe(SubCategoria sc)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.Existe(sc, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public SubCategoria? GetItem(int id)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetItem(id, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public List<SubCategoriaListDto> GetLista(OrdenarCategorias? orden= OrdenarCategorias.Ninguno,
												  Categoria? c=null)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetLista(conexion,null,orden,c);
				}
				catch (Exception)
				{
					throw;
				}
			}
		}

		public List<SubCategoria>GetListaPorCategoria(int categoriaId)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetListaPorCategoria(conexion,categoriaId);
				}
				catch (Exception)
				{
					throw;
				}
			}
		}

		public void Guardar(SubCategoria sc)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (sc.SubCategoriaId == 0)
						{
							_repositorio.Agregar(sc, conexion, tran);
						}
						else
						{
							_repositorio.Editar(sc, conexion, tran);
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
