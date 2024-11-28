namespace FoodStore.Entidades.Dtos
{
	public class ComboListDto
	{
        public int ComboId { get; set; }
        public string? NombreCombo { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioCombo { get; set; }
        public string? NombreTamanio { get; set; }
        public int CantidadProductos { get; set; }
        public bool Vigente { get; set; }

    }
}
