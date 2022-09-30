using System.ComponentModel.DataAnnotations;

namespace SuperHeroes.DTO
{
    public class PersonajeParaEditarDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*Nombre Obligatorio")]
        public string Nombre { get; set; }
        public string? NombreReal { get; set; }
        public string? SuperPoder { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        [Required(ErrorMessage = "*Debe seleccionar una categoria")]
        public int? CategoriaId { get; set; }
        public string? ImagenUrl { get; set; }
    }
}
