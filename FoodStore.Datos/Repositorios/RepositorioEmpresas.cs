using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioEmpresas : IRepositorioEmpresas
	{
		public RepositorioEmpresas()
		{
		}
		public void Agregar(Empresa? e, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Empresas(RazonSocial,Telefono,Email,Direccion,Cuit) 
									   VALUES(@RazonSocial,@Telefono,@Email,@Direccion,@Cuit);
									   SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, e, tran);
			e.EmpresaId = id != 0 ? id : throw new Exception("Error en BD, No ha sido posible agregar el registro");
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM Empresas WHERE EmpresaId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(Empresa? e, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE Empresas SET RazonSocial=@RazonSocial,
														   Telefono=@Telefono,Email=@Email,
														   Direccion=@Direccion,Cuit=@Cuit
									   WHERE EmpresaId=@EmpresaId";
			int rows = conexion.Execute(UpdateQuery, e, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran=null)
		{
			
			string SelectQuery = "SELECT COUNT(*) FROM Proveedores WHERE EmpresaId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Empresa? e, SqlConnection conexion, SqlTransaction? tran=null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Empresas 
								   WHERE RazonSocial=@RazonSocial";
			if (e.EmpresaId != 0)
			{
				SelectQuery += " AND EmpresaId!=@EmpresaId";
			}
			return conexion.QuerySingle<int>(SelectQuery, e) > 0;
		}

		public Empresa? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT RazonSocial,Telefono,Email,Direccion,Cuit FROM Empresas 
										WHERE EmpresaId=@id";
			return (Empresa?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<Empresa>? GetLista(SqlConnection conexion,
									   OrdenarEmpresas? orden = OrdenarEmpresas.Ninguno,
									   string? textoFiltro = null, 
									   SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT RazonSocial,Telefono,Email,Direccion,Cuit 
								   FROM Empresas";
			if (textoFiltro is not null)SelectQuery += $" WHERE RazonSocial LIKE '%'+ @textoFiltro +'%'";
			if (orden is not null)
			{
				switch (orden)
				{
					case OrdenarEmpresas.RazonSocialAZ:
						SelectQuery += " ORDER BY RazonSocial";
						break;
					case OrdenarEmpresas.RazonSocialZA:
						SelectQuery += " ORDER BY RazonSocial DESC";
						break;
					case OrdenarEmpresas.DireccionAZ:
						SelectQuery += " ORDER BY Direccion";
						break;
					case OrdenarEmpresas.DireccionZA:
						SelectQuery += " ORDER BY Direccion DESC";
						break;
				}
			}
			if (textoFiltro is not null) return conexion.Query<Empresa>(SelectQuery, new {textoFiltro}).ToList();
			return conexion.Query<Empresa>(SelectQuery).ToList();
		}
	}
}
