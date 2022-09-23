using SuperHeroes.DTO;

namespace SuperHeroes.NEGOCIO
{
    public interface IPersonajeNegocio
    {
        List<PersonajeDTO> ObtenerTodos();
    }
}
