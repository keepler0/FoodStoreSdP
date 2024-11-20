
using FoodStore.Entidades;
using FoodStore.Entidades.Enums;
using FoodStore.Servicios.Interfaces;
using FoodStore.Servicios.Servicios;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStore.Windows.Helpers
{
	public static class CombosHelper
	{
		private static IServiceProvider? _serviceProvider;
		public static void CargarCombosPaises(ref ComboBox cbxPaises, IServiceProvider? serviceProvider)
		{
			_serviceProvider = serviceProvider;
			IServiciosPaises servicios=_serviceProvider!.GetService<IServiciosPaises>()!;
			var lista = servicios.GetLista();
			var defaultPais = new Pais
			{
				PaisId = 0,
				NombrePais = "Seleccione pais"
			};
			lista.Insert(0,defaultPais);
			cbxPaises.DataSource = lista;
			cbxPaises.DisplayMember = "NombrePais";
			cbxPaises.ValueMember = "PaisId";
		}
		public static void CargarCombosOrden(ref ComboBox cbxOrden,object? obj=null)
		{
			switch (obj)
			{
				case Ordenar:
					cbxOrden.DataSource=Enum.GetValues(typeof(Ordenar));
					break;
				case OrdenarLocalidades:
					cbxOrden.DataSource = Enum.GetValues(typeof(OrdenarLocalidades));
					break;
				case OrdenarCategorias:
					cbxOrden.DataSource = Enum.GetValues(typeof(OrdenarCategorias));
					break;
				case OrdenarEmpresas:
					cbxOrden.DataSource = Enum.GetValues(typeof(OrdenarEmpresas));
					break;
				case OrdenarClientes:
					cbxOrden.DataSource = Enum.GetValues(typeof(OrdenarClientes));
					break;
				case OrdenarEmpleados:
					cbxOrden.DataSource = Enum.GetValues(typeof(OrdenarEmpleados));
					break;
				case OrdenarProductos:
					cbxOrden.DataSource = Enum.GetValues(typeof(OrdenarProductos));
					break;

			}
		}

		public static void CargarCombosProvincias(ref ComboBox cbxProvincias, 
													  IServiceProvider serviceProvider, 
													  Pais? paisSeleccionado)
		{
			_serviceProvider=serviceProvider;
			var servicios = _serviceProvider.GetService<IServiciosProvincias>();
			var lista = servicios!.GetListaPorPais(paisSeleccionado!.PaisId);
			var defaultPr = new Provincia
			{
				ProvinciaId = 0,
				NombreProvincia="Seleccione una provincia"
			};
			lista.Insert(0, defaultPr);
			cbxProvincias.DataSource = lista;
			cbxProvincias.DisplayMember = "NombreProvincia";
			cbxProvincias.ValueMember = "ProvinciaId";
		}

		internal static void CargarCombosCategorias(ref ComboBox cbxCategorias,
														IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
			IServiciosCategorias servicios = serviceProvider.GetService<IServiciosCategorias>()!;
			var lista = servicios.GetLista();
			var defaultCategoria = new Categoria
			{
				CategoriaId = 0,
				NombreCategoria = "Seleccione categoria"
			};
			lista.Insert(0, defaultCategoria);
			cbxCategorias.DataSource= lista;
			cbxCategorias.DisplayMember = "NombreCategoria";
			cbxCategorias.ValueMember = "CategoriaId";
		}

		internal static void CargarCombosLocalidades(ref ComboBox cbxLocalidades, 
													 IServiceProvider serviceProvider, 
													 Provincia provinciaSeleccionada)
		{
			_serviceProvider = serviceProvider;
			var servicios = _serviceProvider.GetService<IServiciosLocalidades>();
			var lista = servicios!.GetListaPorProvincia(provinciaSeleccionada!.ProvinciaId);
			var defaultLoc = new Localidad
			{
				LocalidadId = 0,
				NombreLocalidad = "Seleccione una localidad"
			};
			lista.Insert(0, defaultLoc);
			cbxLocalidades.DataSource = lista;
			cbxLocalidades.DisplayMember = "NombreLocalidad";
			cbxLocalidades.ValueMember = "LocalidadId";
		}

		internal static void CargarCombosRoles(ref ComboBox cbxRoles, IServiceProvider? serviceProvider)
		{
			_serviceProvider = serviceProvider;
			var servicios = _serviceProvider!.GetService<IServiciosRoles>();
			var lista = servicios!.GetLista();
			var defaultRol = new Rol
			{
				RolId = 0,
				NombreRol = "Seleccione un cargo"
			};
			lista.Insert(0, defaultRol);
			cbxRoles.DataSource = lista;
			cbxRoles.DisplayMember = "NombreRol";
			cbxRoles.ValueMember = "RolId";
		}

		internal static void CargarCombosEstados(ref ComboBox cbxEstadoEmpleado, filtroEmpleadosActivos? filtroEstado)
		{
			cbxEstadoEmpleado.DataSource = Enum.GetValues(typeof(filtroEmpleadosActivos));
		}

		internal static void CargarCombosSubCategorias(ref ComboBox cbxSubCategorias, IServiceProvider? serviceProvider, Categoria categoriaSeleccionada)
		{
			_serviceProvider = serviceProvider;
			var servicios = _serviceProvider!.GetService<IServiciosSubCategorias>();
			var lista = servicios!.GetListaPorCategoria(categoriaSeleccionada!.CategoriaId);
			var defaultSc = new SubCategoria
			{
				SubCategoriaId = 0,
				NombreSubCategoria = "Seleccione una sub-categoria"
			};
			lista.Insert(0, defaultSc);
			cbxSubCategorias.DataSource = lista;
			cbxSubCategorias.DisplayMember = "NombreSubCategoria";
			cbxSubCategorias.ValueMember = "SubCategoriaId";
		}
	}
}
