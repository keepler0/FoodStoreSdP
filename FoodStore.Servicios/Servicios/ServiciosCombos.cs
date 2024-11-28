using FoodStore.Datos.Interfaces;
using FoodStore.Datos.Repositorios;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosCombos : IServiciosCombos
	{
		private readonly IRepositorioCombos? _repositorio;
		private readonly string? CadenaConexion;
		public ServiciosCombos(RepositorioCombos repositorio, string cadena)
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

		public bool Existe(Combo? combo)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.Existe(combo, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public Combo? GetItem(int id)
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

		public List<ComboListDto>? GetLista()
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio!.GetLista(conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public void Guardar(Combo? combo)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (combo!.ComboId == 0)
						{
							_repositorio!.Agregar(combo, conexion, tran);
						}
						else
						{
							_repositorio!.Editar(combo, conexion, tran);
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
