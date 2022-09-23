using SuperHeroes.DATOS.Entidades;
using System.Data.SqlClient;

namespace SuperHeroes.DATOS.Repositorios
{
    public class PersonajeRepositorio : IPersonajeRepositorio
    {
        private readonly IConfiguration _configuration;

        public PersonajeRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Personaje> ObtenerTodos()
        {
            var listaPersonajes = new List<Personaje>();
            using SqlConnection sql = new SqlConnection(_configuration.GetConnectionString("conexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_obtener_personajes", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            sql.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nuevoPersonaje = new Personaje 
                    { 
                        Id = (int)reader["Id"], 
                        Nombre = reader["Nombre"].ToString(),
                        FechaNacimiento= reader["FechaNacimiento"]== System.DBNull.Value ? null : (DateTime)reader["FechaNacimiento"],
                        Categoria= reader["Categoria"].ToString()
                    };
                    listaPersonajes.Add(nuevoPersonaje);
                }
            }



            return listaPersonajes;
        }

    }
}
