using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio
{
    public class ProductosModel
    {
        //atributos de la clase formador
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "nutrientes")]
        public string nutrientes{ get; set; }
        [Required]        
        [Display(Name = "nombre de fruta")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Calorias")]
        public string calorias{ get; set; }
        public bool vigente{ get; set; }
    }
}