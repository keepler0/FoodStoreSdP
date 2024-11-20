using FoodStore.Entidades;

namespace FoodStore.Servicios.Interfaces
{
    public interface IServiciosPaises
    {
        void Borrar(int id);
        bool EstaRelacionado(int id);
        bool Existe(Pais c);
        Pais? GetItem(int id);
        List<Pais> GetLista();
        void Guardar(Pais c);
    }
}