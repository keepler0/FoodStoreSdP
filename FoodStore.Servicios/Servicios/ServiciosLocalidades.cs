using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
    public class ServiciosLocalidades : IServiciosLocalidades
	{
		private readonly IRepositorioLocalidades _repositorio;
		private readonly string cadenaConexion = string.Empty;
		public ServiciosLocalidades(IRepositorioLocalidades repositorio,
									string cadenaConexion)
		{
			_repositorio = repositorio;
			this.cadenaConexion = cadenaConexion;
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
			using (var conexion = new SqlConnection(cadenaConexion))
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

		public bool Existe(Localidad c)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
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

		public Localidad? GetItem(int id)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
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

		public List<LocalidadListDto> GetLista(OrdenarLocalidades? ordenar = OrdenarLocalidades.Ninguno,
												Pais? pais = null,
												Provincia? provincia = null)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetLista(conexion,null,ordenar,pais,provincia);
				}
				catch (Exception)
				{

					throw;
				}
			}

		}

		public List<Localidad> GetListaPorProvincia(int id)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetListaPorProvincia(conexion, id);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public void Guardar(Localidad c)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (c.LocalidadId == 0)
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
