using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio
{
    public class ClientesModel
    {
        //atributos de la clase formador
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "nro. Identficación cliente")]
        public string identificacioncli{ get; set; }
        [Required]        
        [Display(Name = "Nombre del cliente")]
        public string nombrecli{ get; set; }
        [Required]        
        [Display(Name = "Correo Electrónico")]
        public string mailcli{ get; set; }
        [Required]        
        [Display(Name = "numero de Celular")]
        public string movilcli{ get; set; }
        public bool vigente{ get; set; }
    }
}