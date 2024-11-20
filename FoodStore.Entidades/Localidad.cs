namespace FoodStore.Entidades
{
	public class Localidad
	{
		public int LocalidadId { get; set; }
		public string NombreLocalidad { get; set; } = null!;
		public int ProvinciaId { get; set; }
        public Provincia? Provincia { get; set; }
    }
}
