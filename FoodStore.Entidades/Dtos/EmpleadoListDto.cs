namespace FoodStore.Entidades.Dtos
{
	public class EmpleadoListDto:ICloneable
	{
        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NombreRol { get; set; }
        public string? Cuit { get; set; }
        public bool Activo { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";

        public object Clone()=>this.MemberwiseClone();

		public static implicit operator EmpleadoListDto(Empleado e)
        {
            return new EmpleadoListDto
            {
                EmpleadoId = e.EmpleadoId,
                Nombre = e.Nombre,
                Apellido = e.Apellido,
                NombreRol = e.Rol?.NombreRol ?? "N/A",
                Cuit = e.Cuit,
                Activo = e.Activo
            };
        }
    }
}
