using FoodStore.Datos.Interfaces;
using FoodStore.Datos.Repositorios;
using FoodStore.Entidades;
using FoodStore.Servicios.Interfaces;
using FoodStore.Servicios.Servicios;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace FoodStore.IoC
{
	public static class DI
	{
		public static IServiceProvider ConfigurarServicios()
		{
			var service = new ServiceCollection();
			var cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

			service.AddScoped<IRepositorioCategorias, RepositorioCategorias>();
			service.AddScoped<IServiciosCategorias>(sp =>
			{
				var repositorio = new RepositorioCategorias();
				return new ServiciosCategorias(repositorio, cadena);
			});

			service.AddScoped<IRepositorioEmpresas, RepositorioEmpresas>();
			service.AddScoped<IServiciosEmpresas>(sp =>
			{
				var repositorio = new RepositorioEmpresas();
				return new ServiciosEmpresas(repositorio, cadena);
			});

			service.AddScoped<IRepositorioGenerico<Estado>, RepositorioEstados>();
			service.AddScoped<IServiciosGenericos<Estado>>(sp =>
			{
				var repositorio = new RepositorioEstados();
				return new ServiciosEstados(repositorio, cadena);
			});

			service.AddScoped<IRepositorioLocalidades, RepositorioLocalidades>();
			service.AddScoped<IServiciosLocalidades>(sp =>
			{
				var repositorio = new RepositorioLocalidades();
				return new ServiciosLocalidades(repositorio, cadena);
			});

			service.AddScoped<IRepositorioGenerico<MetodoPago>, RepositorioMetodosDePagos>();
			service.AddScoped<IServiciosGenericos<MetodoPago>>(sp =>
			{
				var repositorio = new RepositorioMetodosDePagos();
				return new ServiciosMetodosDePagos(repositorio, cadena);
			});

			service.AddScoped<IRepositorioPaises, RepositorioPaises>();
			service.AddScoped<IServiciosPaises>(sp =>
			{
				var repositorio = new RepositorioPaises();
				return new ServiciosPaises(repositorio, cadena);
			});

			service.AddScoped<IRepositorioProvincias, RepositorioProvincias>();
			service.AddScoped<IServiciosProvincias>(sp =>
			{
				var repositorio = new RepositorioProvincias();
				return new ServiciosProvincias(repositorio, cadena);
			});

			service.AddScoped<IRepositorioTamanios, RepositorioTamanios>();
			service.AddScoped<IServiciosTamanios>(sp =>
			{
				var repositorio = new RepositorioTamanios();
				return new ServiciosTamanios(repositorio, cadena);
			});

			service.AddScoped<IRepositorioGenerico<TipoOrden>, RepositorioTiposDeOrden>();
			service.AddScoped<IServiciosGenericos<TipoOrden>>(sp =>
			{
				var repositorio = new RepositorioTiposDeOrden();
				return new ServiciosTiposDeOrden(repositorio, cadena);
			});

			service.AddScoped<IRepositorioEmpleados, RepositorioEmpleados>();
			service.AddScoped<IServiciosEmpleados>(sp =>
			{
				var repositorio = new RepositorioEmpleados();
				return new ServiciosEmpleados(repositorio, cadena);
			});

			service.AddScoped<IRepositorioSubCategorias, RepositorioSubCategorias>();
			service.AddScoped<IServiciosSubCategorias>(sp =>
			{
				var repositorio = new RepositorioSubCategorias();
				return new ServiciosSubCategorias(repositorio, cadena);
			});

			service.AddScoped<IRepositorioClientes, RepositorioClientes>();
			service.AddScoped<IServiciosClientes>(sp =>
			{
				var repositorio = new RepositorioClientes();
				return new ServiciosClientes(repositorio, cadena);
			});

			service.AddScoped<IRepositorioRoles, RepositorioRoles>();
			service.AddScoped<IServiciosRoles>(sp =>
			{
				var repositorio = new RepositorioRoles();
				return new ServiciosRoles(repositorio, cadena);
			});

			service.AddScoped<IRepositorioProductos, RepositorioProductos>();
			service.AddScoped<IServiciosProductos>(sp =>
			{
				var repositorio = new RepositorioProductos();
				return new ServiciosProductos(repositorio, cadena);
			});

			service.AddScoped<IRepositorioCombos, RepositorioCombos>();
			service.AddScoped<IServiciosCombos>(sp =>
			{
				var repositorio = new RepositorioCombos();
				return new ServiciosCombos(repositorio, cadena);
			});
			return service.BuildServiceProvider();
		}
	}
}
