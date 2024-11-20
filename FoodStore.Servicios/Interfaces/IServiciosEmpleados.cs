using FoodStore.Entidades;
using FoodStore.Entidades.Dtos;
using FoodStore.Entidades.Enums;

namespace FoodStore.Servicios.Interfaces
{
	public interface IServiciosEmpleados
	{
		void Borrar(int id);
		bool EstaRelacionado(int id);
		bool Existe(Empleado e);
		Empleado? GetItem(int id);
		List<EmpleadoListDto> GetLista(string? filtroNombre = null, 
									   string? filtroApellido = null,
									   Rol? rol = null,
									   filtroEmpleadosActivos? filtroEstado = filtroEmpleadosActivos.Ninguno,
									   OrdenarEmpleados? orden = OrdenarEmpleados.Ninguno);
		void Guardar(Empleado e);
	}
}
