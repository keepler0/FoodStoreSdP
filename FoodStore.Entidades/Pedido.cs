namespace FoodStore.Entidades
{
	public class Pedido
	{
		public int PedidoId { get; set; }
		public int OrdenId { get; set; }
        public Orden Orden { get; set; } = null!;
		public int EmpleadoId { get; set; }
		public Empleado Empleado { get; set; } = null!;
		public int EstadoId { get; set; }
		public Estado Estado { get; set; } = null!;
	}
}
