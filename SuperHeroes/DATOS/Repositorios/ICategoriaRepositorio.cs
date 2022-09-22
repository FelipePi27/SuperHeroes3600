namespace SuperHeroes.DATOS.Repositorios
{
    public interface ICategoriaRepositorio
    {
        List<Categoria> ObtenerTodas();
        void CrearCategoria(Categoria categoria);
        Categoria ObtenerPorId(int id);
        void ActualizarCategoria(Categoria categoria);
        void EliminarCategoria(int id);
    }
}
