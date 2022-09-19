using SuperHeroes.DATOS.Repositorios;
using SuperHeroes.DTO;

namespace SuperHeroes.NEGOCIO
{
    public class CategoriaNegocio : ICategoriaNegocio
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
            foreach (var categoria in listaCategoriaEntidades)
            {
                var categoriaDto = new CategoriaDTO {Id = categoria.Id,Nombre = categoria.Nombre};  
                listaCategoriasDTO.Add(categoriaDto);   


            }

            return listaCategoriasDTO;
        }
    }
}
