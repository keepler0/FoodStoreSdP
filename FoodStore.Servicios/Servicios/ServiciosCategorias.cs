using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosCategorias : IServiciosCategorias
	{
		private readonly IRepositorioCategorias _repositorio;
		private readonly string CadenaConexion = string.Empty;
		public ServiciosCategorias(IRepositorioCategorias repositorio, string cadena)
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

		public bool Existe(Categoria c)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.Existe(c, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public Categoria? GetItem(int id)
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

		public List<Categoria> GetLista()
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetLista(conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public void Guardar(Categoria c)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (c.CategoriaId == 0)
						{
							_repositorio.Agregar(c, conexion, tran);
						}
						else
						{
							_repositorio.Editar(c, conexion, tran);
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
