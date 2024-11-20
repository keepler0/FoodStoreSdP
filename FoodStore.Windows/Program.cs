using FoodStore.IoC;
using FoodStore.Windows.Forms;
using FoodStore.Windows.Forms.Paises;
using System.Drawing.Printing;

namespace FoodStore.Windows
{
	internal static class Program
	{
		private static IServiceProvider? _serviceProvider;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			_serviceProvider = DI.ConfigurarServicios();
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new frmPrincipal(_serviceProvider));
		}
	}
}