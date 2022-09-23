using SuperHeroes.DATOS.Entidades;

namespace SuperHeroes.DATOS.Repositorios
{
    public interface IPersonajeRepositorio
    {
        List<Personaje> ObtenerTodos();
    }
}
