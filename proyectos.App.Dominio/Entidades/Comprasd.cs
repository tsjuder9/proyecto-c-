using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio
{
    public class ComprasModel
    {
        //atributos de la clase formador
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "comprafruta serial")]
        public string compraserial{ get; set; }
        [Required]        
        [Display(Name = "compra cantidad de articlos")]
        public string cantidadarticulos{ get; set; }
        [Required]        
        [Display(Name = "direccion de lugar")]
        public string direcccioncli{ get; set; }
        [Required]        
        [Display(Name = "numero de celular")]
        public string movil{ get; set; }
         [Required]        
        [Display(Name = "compra arbol id arbol")]
        public string compraarbol{ get; set; }
        [Required]        
        [Display(Name = "Correo Electrónico del cliente")]
        public string mailcli{ get; set; }
        [Required]        
        [Display(Name = "nutrientes")]
        public string nutrientes{ get; set; }
        public bool vigente{ get; set; }
    }
}