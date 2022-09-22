using SuperHeroes.DATOS;
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

        public void CrearCategoria(CategoriaDTO categoriaDTO) 
        {

            var categoria = new Categoria { Nombre = categoriaDTO.Nombre };
            _categoriaRepositorio.CrearCategoria(categoria);
        }

        public CategoriaDTO ObtenerCategoriaPorId(int id) 
        {
        
            var categoria = _categoriaRepositorio.ObtenerPorId(id);
            var categoriaDTO = new CategoriaDTO { Id = categoria.Id, Nombre = categoria.Nombre };  
            return categoriaDTO;    
        }

        public void ActualizarCategoria(CategoriaDTO categoriaDTO)
        {

            var categoria = new Categoria { Id= categoriaDTO.Id,Nombre = categoriaDTO.Nombre };
            _categoriaRepositorio.ActualizarCategoria(categoria);
        }

        public void EliminarCategoria(int id) 
        {
            _categoriaRepositorio.EliminarCategoria(id);
        }
    }
}
