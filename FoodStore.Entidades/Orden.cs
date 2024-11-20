namespace FoodStore.Entidades
{
	public class Orden
	{
		public int OrdenId { get; set; }
		public int ClienteId { get; set; }
		public Cliente Cliente { get; set; } = null!;
		public int EstadoId { get; set; }
		public Estado Estado { get; set; } = null!;
		public int TipoOrdenId { get; set; }
		public TipoOrden TipoOrden { get; set; } = null!;
		public int DetalleId { get; set; }
		public Detalle Detalle { get; set; } = null!;
		public int EmpleadoId { get; set; }
		public Empleado Empleado { get; set; } = null!;
		public int PagoId { get; set; }
		public MetodoPago MetodoPago { get; set; } = null!;
		public decimal Total { get; set; }
		public DateTime FechaHora { get; set; }
	}
}
