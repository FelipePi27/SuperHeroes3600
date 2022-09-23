namespace SuperHeroes.DATOS.Entidades
{
    public class Personaje
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreReal { get; set; }
        public string SuperPoder { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }
        public string ImagenUrl { get; set; }
    }

}
