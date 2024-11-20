using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosProvincias : IServiciosProvincias
	{
		private readonly IRepositorioProvincias _repositorio;
		private readonly string cadenaConexion = string.Empty;
		public ServiciosProvincias(IRepositorioProvincias repositorio,
									string cadena)
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

		public bool Existe(Provincia c)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
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

		public Provincia? GetItem(int id)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
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

		public List<ProvinciaListDto> GetLista(Ordenar? ordenar=Ordenar.Ninguno,
											   Pais? pais=null)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				try
				{
					return _repositorio.GetLista(conexion,null,ordenar,pais);
				}
				catch (Exception)
				{

					throw;
				}
			}

		}

		public List<Provincia> GetListaPorPais(int PaisId)
		{
			using (var conexion=new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetListaPorPais(conexion,PaisId);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public void Guardar(Provincia c)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (c.ProvinciaId == 0)
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
