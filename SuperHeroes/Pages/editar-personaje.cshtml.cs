using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperHeroes.DTO;
using SuperHeroes.NEGOCIO;

namespace SuperHeroes.Pages
{
    public class editar_personajeModel : PageModel 
    {
        private readonly IPersonajeNegocio _personajeNegocio;

        public editar_personajeModel(IPersonajeNegocio personajeNegocio)
        {
            _personajeNegocio = personajeNegocio;
        }
        [BindProperty]
        public PersonajeParaEditarDTO Personaje { get; set; }
        public SelectList Categorias { get; set; }
        [BindProperty]
        public int Id { get; set; } 
        public void OnGet(int id)
        {
           Id = id;
            var personajeParaEditarDTO = _personajeNegocio.ObtenerPersonajePorId(id);
            Personaje = personajeParaEditarDTO;
            Categorias = _personajeNegocio.ObtenerCategoriasLista();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Personaje.Id = Id;  
          
                _personajeNegocio.ActualizarPersonaje(Personaje);
                return RedirectToPage("./personajes");
            }
            Categorias = _personajeNegocio.ObtenerCategoriasLista();
            return Page();
        }

    }
}
