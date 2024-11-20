namespace FoodStore.Entidades
{
	public class Historial
	{
		public int HistorialId { get; set; }
		public int ProductoId { get; set; }
		public Producto? Producto { get; set; }
		public int Cantidad { get; set; }
		public int TipoMovimientoId { get; set; }
		public TipoMovimiento? TipoMovimiento { get; set; }
		public DateOnly FechaMovimiento { get; set; }
		public int EmpleadoId { get; set; }
		public Empleado? Epleado { get; set; }
		public string? Motivo { get; set; }
	}
}
