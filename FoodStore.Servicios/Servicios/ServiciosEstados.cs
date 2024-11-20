using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosEstados : IServiciosGenericos<Estado>
	{
		private IRepositorioGenerico<Estado> _repositorio;
		private readonly string CadenaConexion = string.Empty;
		public ServiciosEstados(IRepositorioGenerico<Estado> repositorio,
								string Cadena)
		{
			_repositorio = repositorio;
			CadenaConexion = Cadena;
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

		public bool Existe(Estado item)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.Existe(item, conexion);
				}
				catch (Exception)

				{
					throw;
				}
			}
		}

		public Estado? GetItem(int id)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetItem(id, conexion);
				}
				catch (Exception) { throw; }
			}
		}

		public List<Estado> GetLista()
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
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

		public void Guardar(Estado item)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (item.EstadoId == 0)
						{
							_repositorio.Agregar(item, conexion, tran);
						}
						else
						{
							_repositorio.Editar(item, conexion, tran);
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
