using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroes.NEGOCIO;

namespace SuperHeroes.Pages
{
    public class eliminar_categoriaModel : PageModel
    {
        private readonly ICategoriaNegocio _categoriaNegocio;

        public eliminar_categoriaModel(ICategoriaNegocio categoriaNegocio)
        {
            _categoriaNegocio = categoriaNegocio;
        }
        [BindProperty]
        public int Id { get; set; } 
        public void OnGet(int id)
        {
            Id = id;    
        }
        public IActionResult OnPost() 
        {
            _categoriaNegocio.EliminarCategoria(Id);
            return RedirectToPage("./categorias");
        }
    }
}
