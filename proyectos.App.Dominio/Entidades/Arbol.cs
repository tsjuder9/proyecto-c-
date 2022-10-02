using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio
{
    public class ArbolModel
    {
        //atributos de la clase formador
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Numero nutrientes")]
        public string nutrientes{ get; set; }
        [Required]        
        [Display(Name = "Nombre del arbol")]
        public string nombrearbol{ get; set; }
        //[Required]        
       // [Display(Name = "Correo Electrónico")]
        //public string mail{ get; set; }
        public bool vigente{ get; set; }
    }
}