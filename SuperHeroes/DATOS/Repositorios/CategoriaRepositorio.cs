using SuperHeroes.DATOS.Repositorios;
using System.Data.SqlClient;

namespace SuperHeroes.DATOS
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly IConfiguration _configuration;

        public CategoriaRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<Categoria> ObtenerTodas()
        {
            var listaCategoria = new List<Categoria>();
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("conexionPorDefecto")); 
            using SqlCommand cmd = new SqlCommand("sp_obtener_categorias", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure; 
            sql.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nuevaCategoria = new Categoria {Id =(int)reader["Id"],Nombre = reader["Nombre"].ToString() };  
                    listaCategoria.Add(nuevaCategoria); 
                }
            }
                


            return listaCategoria;
        }

        public void CrearCategoria(Categoria categoria)
        {
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("conexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_insertar_categoria", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));
            sql.Open();
            cmd.ExecuteNonQuery();
        }

        public Categoria ObtenerPorId(int id)
        {
            var categoria = new Categoria();
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("conexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_obtener_categoria_por_id", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            sql.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nuevaCategoria = new Categoria { Id = (int)reader["Id"], Nombre = reader["Nombre"].ToString() };
                    categoria = nuevaCategoria;
                }
            }

             return categoria;
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("conexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_actualiza_categoria", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", categoria.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));
            sql.Open();
            cmd.ExecuteNonQuery();
        }

        public void EliminarCategoria(int id)
        {
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("conexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_eliminar_categoria", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            sql.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
