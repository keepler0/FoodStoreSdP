using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioEstados : IRepositorioGenerico<Estado>
	{
        public RepositorioEstados()
        {
        }
        public void Agregar(Estado item, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Estados(Descripcion) VALUES(@Descripcion);
									  SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, item,tran);
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = @"DELETE FROM Estados WHERE EstadoId=@EstadoId";
			int rows = conexion.Execute(DeleteQuery, new { id },tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(Estado item, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE Estados SET Descripcion=@Descripcion
									   WHERE EstadoId=@EstadoId";
			int rows = conexion.Execute(UpdateQuery, item, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran=null)
		{
			string SelectQuery = "SELECT COUNT(*) FROM Ordenes WHERE EstadoId=@EstadoId";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Estado item, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Estados 
										WHERE Descripcion=@Descripcion";
			if (item.EstadoId != 0)
			{
				SelectQuery += " AND EstadoId!=@EstadoId";
			}
			return conexion.QuerySingle<int>(SelectQuery, item) > 0;
		}

		public Estado? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT RazonSocial,Telefono,Email,Direccion,Cuit FROM Empresas 
										WHERE EmpresaId=@EmpresaId";
			return (Estado?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<Estado> GetLista(SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT EstadoId,Descripcion
									   FROM Estados
									   ORDER BY Descripcion";
			return conexion.Query<Estado>(SelectQuery).ToList();
		}
	}
}
