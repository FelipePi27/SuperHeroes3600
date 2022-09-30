using Microsoft.AspNetCore.Mvc.Rendering;
using SuperHeroes.DATOS;
using SuperHeroes.DATOS.Entidades;
using SuperHeroes.DATOS.Repositorios;
using SuperHeroes.DTO;
using System.Reflection.Metadata.Ecma335;

namespace SuperHeroes.NEGOCIO
{
    public class PersonajeNegocio : IPersonajeNegocio
    {
        private readonly IPersonajeRepositorio _personajeRepositorio;

        public PersonajeNegocio(IPersonajeRepositorio personajeRepositorio)
        {
            _personajeRepositorio = personajeRepositorio;
        }
        public List<PersonajeDTO> ObtenerTodos()
        {
            var listaDTO = new List<PersonajeDTO>();
            var listaEntidades = _personajeRepositorio.ObtenerTodos();  

            foreach (var entidad in listaEntidades) 
            {
                var nuevoPersonajeDTO = new PersonajeDTO() 
                {
                    Id = entidad.Id,
                    Categoria = entidad.Categoria,  
                    FechaNacimiento = entidad.FechaNacimiento,  
                    Nombre = entidad.Nombre,    
                
                
                }; 
                listaDTO.Add(nuevoPersonajeDTO);    
            
            
            }


            return listaDTO;
        
        }

    }
}
