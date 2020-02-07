using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppPedidos.BaseDatos.clsModelos
{
    public class tblProducto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]        
        public int IdProducto { get; set; }

        public int PluProducto { get; set; }
        [StringLength(300)]  
        public string NombreProducto { get; set; }
        [StringLength(500)]
        [Required]
        public string DescripcionProducto { get; set; }
        [StringLength(100)]
        [Required]
        public string MarcaProducto { get; set; }
        public int CantidadDisponible { get; set; }
        public float ValorProducto { get; set; }
        public float IvaProducto { get; set; }
        [StringLength(500)]
        [Required]
        public string ObservacionProducto { get; set; }
    }
}
