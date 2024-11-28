using Dapper;
using FoodStore.Datos.Interfaces;
using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;
using System.Data.SqlClient;

namespace FoodStore.Datos.Repositorios
{
	public class RepositorioCombos:IRepositorioCombos
	{
		public void Agregar(Combo? combo, SqlConnection conexion, SqlTransaction tran)
		{
			string InsertQuery = @"INSERT INTO Combos(NombreCombo,FechaInicio,FechaFin,Descripcion,PrecioCombo,
														TamanioId,Imagen)
									VALUES(@NombreCombo,@FechaInicio,@FechaFin,@Descripcion,@PrecioCombo,
										   @TamanioId,@Imagen);
									SELECT SCOPE_IDENTITY()";
			int id = conexion.QuerySingle<int>(InsertQuery, combo, tran);
			if (id == 0) throw new Exception("No ha sido posible agregar el registro");
			combo.ComboId = id;
		}

		public void Borrar(int id, SqlConnection conexion, SqlTransaction? tran)
		{
			string DeleteQuery = "DELETE FROM Cobos WHERE ComboId=@id";
			int rows = conexion.Execute(DeleteQuery, new { id }, tran);
			if (rows == 0) throw new Exception("No ha sido posible borrar el registro");
		}

		public void Editar(Combo? combo, SqlConnection conexion, SqlTransaction? tran)
		{
			string UpdateQuery = @"UPDATE Combos SET NombreCombo=@NombreCombo,FechaInicio=@FechaInicio,
									FechaFin=@FechaFin,Descripcion=@Descripcion,PrecioCombo=@PrecioCombo,
									TamanioId=@TamanioId,
									Imagen=@Imagen
									WHERE ComboId=@ComboId";
			int rows = conexion.Execute(UpdateQuery, combo, tran);
			if (rows == 0) throw new Exception("Error en BD, No ha sido posible editar el registro");
		}

		public bool EstaRelacionado(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT COUNT(*) FROM Ordenes 
								   WHERE ComboId=@id";
			return conexion.QuerySingle<int>(SelectQuery, new { id }) > 0;
		}

		public bool Existe(Combo? combo, SqlConnection conexion, SqlTransaction? tran = null)
		{
			if (combo is null) throw new ArgumentException("Error: combo con valor null");
			string SelectQuery = @"SELECT COUNT(*) FROM Combos 
								   WHERE NombreCombo=@NombreCombo";
			if (combo.ComboId != 0)
			{
				SelectQuery += " AND ComboId<>@ComboId";
			}
			return conexion.QuerySingle<int>(SelectQuery, combo) > 0;
		}

		public Combo? GetItem(int id, SqlConnection conexion, SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT ComboId,NombreCombo,FechaInicio,FechaFin,
										  Descripcion,PrecioCombo,TamanioId,Imagen
										FROM Combos 
										WHERE ComboId=@id";
			return conexion.QuerySingle<Combo?>(SelectQuery, new { id });
		}

		public List<ComboListDto>? GetLista(SqlConnection conexion,
											 SqlTransaction? tran = null)
		{
			string SelectQuery = @"SELECT c.NombreCombo,c.Descripcion,t.NombreTamanio,
									(SELECT SUM(cp.Cantidad) 
										FROM CombosProductos cp 
										WHERE cp.ComboId=c.ComboId) AS CantidadProductos,
									c.PrecioCombo,
									CASE 
										WHEN c.FechaFin < GETDATE() THEN 1
										ELSE 0
									END AS Vigente
									FROM Combos c
									INNER JOIN Tamanios t ON c.TamanioId=t.TamanioId";
			//if (!string.IsNullOrEmpty(nombre) &&
			//	!string.IsNullOrEmpty(direccion))
			//{
			//	SelectQuery += @$" WHERE NombreCompleto LIKE '%{nombre}%' 
			//					   AND DireccionCompleta LIKE '%{direccion}%'";
			//}
			//else if (!string.IsNullOrEmpty(nombre) &&
			//		 !string.IsNullOrEmpty(direccion))
			//{
			//	SelectQuery += @$" NombreCompleto LIKE '%{nombre}%' 
			//					   AND DireccionCompleta LIKE '%{direccion}%'";
			//}
			//else if (!string.IsNullOrEmpty(nombre))
			//{
			//	SelectQuery += @$" WHERE NombreCompleto LIKE '%{nombre}%'";
			//}
			//else if (!string.IsNullOrEmpty(direccion))
			//{
			//	SelectQuery += @$" WHERE DireccionCompleta LIKE '%{direccion}%'";
			//}
			//switch (orden)
			//{
			//	case OrdenarClientes.Ninguno:
			//		break;
			//	case OrdenarClientes.NombreCompletoAZ:
			//		SelectQuery += " ORDER BY NombreCompleto";
			//		break;
			//	case OrdenarClientes.NombreCompletoZA:
			//		SelectQuery += " ORDER BY NombreCompleto DESC";
			//		break;
			//	case OrdenarClientes.DireccionAZ:
			//		SelectQuery += " ORDER BY DireccionCompleta";
			//		break;
			//	case OrdenarClientes.DireccionZA:
			//		SelectQuery += " ORDER BY DireccionCompleta DESC";
			//		break;
			//}
			return conexion.Query<ComboListDto>(SelectQuery).ToList();
		}
	}
}
