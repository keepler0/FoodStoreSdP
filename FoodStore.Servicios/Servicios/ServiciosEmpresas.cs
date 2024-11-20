using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosEmpresas : IServiciosEmpresas
	{
		private IRepositorioEmpresas? _repositorio;
		private readonly string cadenaConexion = string.Empty;
		public ServiciosEmpresas(IRepositorioEmpresas? repositorio, string cadena)
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
			using (var conexion = new SqlConnection(cadenaConexion))
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

		public bool Existe(Empresa? item)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.Existe(item, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public Empresa? GetItem(int id)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
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

		public List<Empresa>? GetLista(OrdenarEmpresas? orden = OrdenarEmpresas.Ninguno,
									   string? textoFiltro = null)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.GetLista(conexion,orden,textoFiltro);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public void Guardar(Empresa? item)
		{
			using (var conexion = new SqlConnection(cadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (item.EmpresaId == 0)
						{
							_repositorio!.Agregar(item, conexion, tran);
						}
						else
						{
							_repositorio!.Editar(item, conexion, tran);
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
