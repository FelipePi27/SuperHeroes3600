using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroes.DTO;
using SuperHeroes.NEGOCIO;

namespace SuperHeroes.Pages
{
    public class personajesModel : PageModel
    {
        private readonly IPersonajeNegocio _personajeNegocio;

        public personajesModel(IPersonajeNegocio personajeNegocio)
        {
            _personajeNegocio = personajeNegocio;
        }
        public List<PersonajeDTO> personajes { get; set; } 
        public void OnGet()
        {
            personajes = _personajeNegocio.ObtenerTodos();

        }
    }
}
