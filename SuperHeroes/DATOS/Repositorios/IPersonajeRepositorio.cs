using SuperHeroes.DATOS.Entidades;

namespace SuperHeroes.DATOS.Repositorios
{
    public interface IPersonajeRepositorio
    {
        void ActualizarPersonaje(Personaje personaje);
        void CrearPersonaje(Personaje personaje);
        void EliminarPersonaje(int id);
        void EliminarPersonje(int id);
        Personaje ObtenerPorId(int id);
        List<Personaje> ObtenerTodos();
    }
}
