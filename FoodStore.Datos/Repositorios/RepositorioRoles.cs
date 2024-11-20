using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioRoles : IRepositorioRoles
	{
		public List<Rol> GetLista(SqlConnection conexion)
		{
			string SelectQuery = "SELECT RolId,NombreRol FROM Roles";
			return conexion.Query<Rol>(SelectQuery).ToList();
		}
	}
}
