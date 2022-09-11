using SuperHeroes.DATOS.Repositorios;
using SuperHeroes.DTO;

namespace SuperHeroes.NEGOCIO
{
    public class CategoriaNegocio
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaNegocio(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }
        public List<CategoriaDTO> ObtenerCategorias() 
        {
            var listaCategoriasDTO = new List<CategoriaDTO>();
            var listaCategoriaEntidades = _categoriaRepositorio.ObtenerTodas();

            return listaCategoriasDTO;
        }
    }
}
