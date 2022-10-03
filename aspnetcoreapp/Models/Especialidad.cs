using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Turnos2.Models
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad {get; set;}
        [StringLength(200)]
        [Required(ErrorMessage ="Debe ingresar una descripción")]
        [Display(Name ="Descripción", Prompt ="Ingrese una descripción")]
        public string Descripcion {get; set;}
        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }
    }
}