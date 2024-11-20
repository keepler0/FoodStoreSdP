using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Entidades
{
	public class Proveedor
	{
        public int ProveedorId { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public int LocalidadId { get; set; }
        public Localidad Localidad { get; set; } = null!;
        public int? EmpresaId { get; set; }
        public Empresa? Empresa { get; set; }
    }
}
