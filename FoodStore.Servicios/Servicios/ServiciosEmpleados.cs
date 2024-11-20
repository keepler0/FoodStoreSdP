using FoodStore.Datos.Interfaces;
using FoodStore.Datos.Repositorios;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using System.Data.SqlClient;

namespace FoodStore.Servicios.Servicios
{
	public class ServiciosEmpleados : IServiciosEmpleados
	{
		private readonly IRepositorioEmpleados _repositorio;
		private readonly string CadenaConexion;
        public ServiciosEmpleados(RepositorioEmpleados repositorio, string cadena)
        {
            CadenaConexion= cadena;
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

		public bool Existe(Empleado e)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.Existe(e, conexion);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public Empleado? GetItem(int id)
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

		public List<EmpleadoListDto> GetLista(string? filtroNombre = null, 
											  string? filtroApellido = null,
											  Rol? rol = null,
									filtroEmpleadosActivos? filtroEstado = filtroEmpleadosActivos.Ninguno,
									OrdenarEmpleados? orden = OrdenarEmpleados.Ninguno)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				try
				{
					return _repositorio.GetLista(conexion,null,filtroNombre,filtroApellido,
												 rol,filtroEstado,orden);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public void Guardar(Empleado e)
		{
			using (var conexion = new SqlConnection(CadenaConexion))
			{
				conexion.Open();
				using (var tran = conexion.BeginTransaction())
				{
					try
					{
						if (e.EmpleadoId == 0)
						{
							_repositorio.Agregar(e, conexion, tran);
						}
						else
						{
							_repositorio.Editar(e, conexion, tran);
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
