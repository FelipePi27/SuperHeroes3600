using Microsoft.AspNetCore.Mvc.Rendering;
using SuperHeroes.DTO;

namespace SuperHeroes.NEGOCIO
{
    public interface IPersonajeNegocio
    {
        void ActualizarPersonaje(PersonajeParaEditarDTO personajeParaEditarDTO);
        void CrearPersonaje(PersonajeParaGuardarDTO personajeParaGuardarDTO);
        void EliminarPersonaje(int id);
        SelectList ObtenerCategoriasLista();
        PersonajeParaEditarDTO ObtenerPersonajePorId(int id);
        List<PersonajeDTO> ObtenerTodos();
    }
}
