using FoodStore.Datos.Interfaces;
using FoodStore.Datos.Repositorios;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosClientes : IServiciosClientes
	{
		private readonly IRepositorioClientes? _repositorio;
		private readonly string? CadenaConexion;
		public ServiciosClientes(RepositorioClientes repositorio, string cadena)
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

		public bool Existe(Cliente cl)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.Existe(cl, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public Cliente? GetItem(int id)
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

		public List<ClienteListDto> GetLista(string? nombre = null,
											 string? direccion = null,
											 OrdenarClientes? orden = OrdenarClientes.Ninguno)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.GetLista(conexion,null,nombre,direccion,orden);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public void Guardar(Cliente cl)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (cl.ClienteId == 0)
						{
							_repositorio!.Agregar(cl, conexion, tran);
						}
						else
						{
							_repositorio!.Editar(cl, conexion, tran);
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
