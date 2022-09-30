using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperHeroes.DTO;
using SuperHeroes.NEGOCIO;

namespace SuperHeroes.Pages
{
    public class nuevo_personajeModel : PageModel
    {
        private readonly IPersonajeNegocio _personajeNegocio;

        public nuevo_personajeModel(IPersonajeNegocio personajeNegocio)
        {
            _personajeNegocio = personajeNegocio;
        }
        public SelectList Categorias { get; set; }
        [BindProperty]
        public PersonajeParaGuardarDTO Personaje { get; set; }    
        public void OnGet()
        {
            Categorias = _personajeNegocio.ObtenerCategoriasLista();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

               _personajeNegocio.CrearPersonaje(Personaje); 
                return RedirectToPage("./personajes");
            }
            Categorias = _personajeNegocio.ObtenerCategoriasLista();
            return Page();

        }
    }
}
