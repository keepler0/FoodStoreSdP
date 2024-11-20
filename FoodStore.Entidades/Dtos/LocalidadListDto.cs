namespace FoodStore.Entidades.Dtos
{
	public class LocalidadListDto
	{
		public int LocalidadId { get; set; }
		public string? NombreLocalidad { get; set; }
		public string? NombreProvincia { get; set; }
		public string? NombrePais { get; set; }
		public string? NombreCompleto => $"{NombreLocalidad}, {NombreProvincia}";

        public static implicit operator LocalidadListDto(Localidad l)
		{
			return new LocalidadListDto
			{
				LocalidadId = l.LocalidadId,
				NombreLocalidad = l.NombreLocalidad,
				NombreProvincia = l.Provincia?.NombreProvincia ?? "N/A",
				NombrePais = l.Provincia?.Pais?.NombrePais ?? "N/A"
			};
		}
	}
}
