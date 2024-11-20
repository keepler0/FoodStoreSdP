using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosTamanios : IServiciosGenericos<Tamanio>
	{
		private readonly IRepositorioGenerico<Tamanio> _repositorio;
		private readonly string cadenaConexion = string.Empty;
		public ServiciosTamanios(IRepositorioGenerico<Tamanio> repositorio,string cadena)
		{
			_repositorio = repositorio;
			cadenaConexion = cadena;
		}
		public void Borrar(int id)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						_repositorio.Borrar(id,conexion,tran);
					}
					catch (Exception)
					{

						throw;
					}

				}
			}
		}

		public bool EstaRelacionado(int id)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.EstaRelacionado(id,conexion);
				}
				catch (Exception)
				{

					throw;
				}

			}
		}

		public bool Existe(Tamanio c)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.Existe(c,conexion);
				}
				catch (Exception)
				{

					throw;
				}

			}
		}

		public Tamanio? GetItem(int id)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetItem(id,conexion);
				}
				catch (Exception)
				{

					throw;
				}

			}
		}

		public List<Tamanio> GetLista()
		{
			using (var conexion = new SqlConnection(cadenaConexion))
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

		public void Guardar(Tamanio c)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				using (var tran=conexion.BeginTransaction())
				{
					try
					{
						if (c.TamanioId == 0)
						{
							_repositorio.Agregar(c,conexion,tran);
						}
						else
						{
							_repositorio.Editar(c,conexion,tran);
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
