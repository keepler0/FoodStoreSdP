using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioMetodosDePagos:IRepositorioGenerico<MetodoPago>
	{
		public RepositorioMetodosDePagos()
		{
		}
		public void Agregar(MetodoPago p,SqlConnection conexion,SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO MetodosPagos(Descripcion) VALUES(@Descripcion);
									   SELECT @@IDENTITY";
			int id = conexion.QuerySingle<int>(InsertQuery, p,tran);
			p.PagoId = id != 0 ? id : throw new Exception("Error en BD, No ha sido posible agregar el registro");
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction tran)
		{
			string DeleteQuery = "DELETE FROM MetodosPagos WHERE PagoId=@PagoId";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible eliminar el registro");
		}

		public void Editar(MetodoPago p, SqlConnection conexion, SqlTransaction tran)
		{
			string UpdateQuery = @"UPDATE MetodosPagos SET Descripcion=@Descripcion
									   WHERE PagoId=@PagoId";
			int rows = conexion.Execute(UpdateQuery, p, tran);
			if (rows == 0)
				throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran=null)
		{
			string SelectQuery = "SELECT COUNT(*) FROM Ordenes WHERE PagoId=@PagoId";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(MetodoPago p, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM MetodosPagos 
										WHERE Descripcion=@Descripcion";
			if (p.PagoId != 0)
			{
				SelectQuery += " AND PagoId<>@PagoId";
			}
			return conexion.QuerySingle<int>(SelectQuery, p) > 0;
		}

		public MetodoPago? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT PagoId,Descripcion FROM MetodosPagos 
										WHERE PagoId=@PagoId";
			return (MetodoPago?)conexion.ExecuteScalar(SelectQuery, new { id });
		}

		public List<MetodoPago> GetLista(SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT PagoId,Descripcion 
									   FROM MetodosPagos
									   ORDER BY Descripcion";
			return conexion.Query<MetodoPago>(SelectQuery).ToList();
		}
	}
}
