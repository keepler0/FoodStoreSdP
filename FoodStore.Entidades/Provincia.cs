namespace FoodStore.Entidades
{
	public class Provincia
	{
        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; } = null!;
        public int PaisId { get; set; }
        public Pais Pais { get; set; } = null!;
    }
}
