namespace FoodStore.Entidades
{
	public class SubCategoria
	{
		public int SubCategoriaId { get; set; }
		public string NombreSubCategoria { get; set; } = null!;
		public int CategoriaId { get; set; }
		public Categoria? Categoria { get; set; } = null!;
	}
}
