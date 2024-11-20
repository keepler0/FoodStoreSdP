namespace FoodStore.Entidades.Dtos
{
	public class ClienteListDto : ICloneable
	{
		public int ClienteId { get; set; }
		public string? NombreCompleto { get; set; }
		public string? DireccionCompleta { get; set; }
		public string? Telefono { get; set; }

		public object Clone() => this.MemberwiseClone();
		public static implicit operator ClienteListDto(Cliente cliente)
		{
			return new ClienteListDto
			{
				ClienteId = cliente.ClienteId,
				NombreCompleto = $"{cliente.Nombre} {cliente.Apellido}",
				DireccionCompleta = $"{cliente.Calle1} {cliente.Calle2} {cliente.NumeroCasa}",
				Telefono = cliente.Telefono
			};
		}
	}
}
