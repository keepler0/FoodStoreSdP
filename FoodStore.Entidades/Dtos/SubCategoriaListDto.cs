namespace FoodStore.Entidades.Dtos
{
	public class SubCategoriaListDto:ICloneable
	{
		public int SubCategoriaId { get; set; }
		public string? NombreSubCategoria { get; set; }
		public string? NombreCategoria { get; set; }

		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public static implicit operator SubCategoriaListDto(SubCategoria sc)
		{
			return new SubCategoriaListDto
			{
				SubCategoriaId = sc.SubCategoriaId,
				NombreSubCategoria = sc.NombreSubCategoria,
				NombreCategoria = sc.Categoria?.NombreCategoria??"N/A"
			};
		}
	}
}
