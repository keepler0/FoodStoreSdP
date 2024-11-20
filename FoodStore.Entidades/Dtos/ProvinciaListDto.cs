namespace FoodStore.Entidades.Dtos
{
	public class ProvinciaListDto
	{
		public int ProvinciaId { get; set; }
		public string NombreProvincia { get; set; } = null!;
		public string NombrePais { get; set; } = null!;
		public string NombreCompleto => $"{NombreProvincia}-{NombrePais}";

		public static implicit operator ProvinciaListDto(Provincia pe)
		{
			return new ProvinciaListDto
			{
				ProvinciaId = pe.ProvinciaId,
				NombreProvincia = pe.NombreProvincia,
				NombrePais = pe.Pais.NombrePais
			};
		}
	}
}
