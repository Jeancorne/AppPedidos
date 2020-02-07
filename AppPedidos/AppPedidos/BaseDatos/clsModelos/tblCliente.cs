using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppPedidos.BaseDatos.clsModelos
{
    public class tblCliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int IdCliente { get; set; }
      
        [StringLength(70)]
        [Required]
        public string NombreCliente { get; set; }
      
        [StringLength(70)]
        [Required]
        public string ApellidoCliente { get; set; }
        public int CedulaCliente { get; set; }
       
        [StringLength(70)]
        [Required]
        public string EmailCliente { get; set; }
        public int TelefonoCliente { get; set; }
     
        [StringLength(150)]
        [Required]
        public string DireccionCliente { get; set; }
        [StringLength(50)]
        [Required]
        public string Ciudad { get; set; }
    }
}
