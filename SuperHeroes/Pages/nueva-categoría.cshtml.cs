using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroes.DTO;
using SuperHeroes.NEGOCIO;
using System.ComponentModel.DataAnnotations;

namespace SuperHeroes.Pages
{
    public class nueva_categoríaModel : PageModel
    {
        private readonly ICategoriaNegocio _categoriaNegocio;

        public nueva_categoríaModel(ICategoriaNegocio categoriaNegocio)
        {
            _categoriaNegocio = categoriaNegocio;
        }
        [BindProperty]
        [Required(ErrorMessage ="*Nombre Obligatorio")]
        
        public string Nombre { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            if (ModelState.IsValid) 
            {
                var categoriaDTO = new CategoriaDTO { Nombre = Nombre };
                _categoriaNegocio.CrearCategoria(categoriaDTO);
                return RedirectToPage("./categorias");

            }

            return Page();  
        
        } 

           
        
    }
}
