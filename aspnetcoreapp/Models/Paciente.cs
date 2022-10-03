using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos2.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente {get; set;}
        [Required(ErrorMessage ="Debe ingresar un Nombre")]  
        public string Nombre {get; set;}
        [Required(ErrorMessage ="Debe ingresar un Apellido")]
        public string Apellido {get; set;}
        [Required(ErrorMessage ="Debe ingresar una dirección")]
        [Display(Name ="Dirección")]
        public string Direccion {get; set;}
        [Required(ErrorMessage ="Debe ingresar un telefono")]
        [Display(Name ="Teléfono")]
        public string Telefono {get; set;}
        [Required(ErrorMessage ="Debe ingresar un email")]
        [EmailAddress(ErrorMessage ="No es una direccion de email valida")]
        public string Email {get; set;}
        public List<Turno> Turno {get; set;}
        
    }
}