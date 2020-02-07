using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppPedidos.BaseDatos.clsModelos
{
    public class tblPedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int IdPedido { get; set; }

        [StringLength(100)]
        [Required]
        public string NombreRecibe { get; set; }
        [StringLength(300)]
        [Required]
        public string ObservacionGeneral { get; set; }
        public int TotalProductos { get; set; }       
        public int ValorTotalPedido { get; set; }
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual tblCliente Cliente { get; set; }

        public int IdProducto { get; set; }
        [ForeignKey("IdProducto")]
        public virtual tblProducto Producto { get; set; }
    }
}
