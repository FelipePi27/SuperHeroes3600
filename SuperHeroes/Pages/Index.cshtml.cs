using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroes.DTO;
using SuperHeroes.NEGOCIO;

namespace SuperHeroes.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonajeNegocio _personajeNegocio;

        public IndexModel(ILogger<IndexModel> logger,IPersonajeNegocio personajeNegocio)
        {
            _logger = logger;
            _personajeNegocio = personajeNegocio;
        }

        public List<PersonajeParaGuardarDTO> personajes { get; set; }

        public void OnGet()
        {
            personajes = _personajeNegocio.ObtenerTodosIndex();
        }
    }
}