using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPedidos.Modelos.Request
{
    public class ClienteRequest
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public int CedulaCliente { get; set; }
        public string EmailCliente { get; set; }
        public int TelefonoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string Ciudad { get; set; }
    }
    public class FiltrarProducto
    {
        public string Filtro { get; set; }
    }
    public class ProductoRequest
    {
        public int PluProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string MarcaProducto { get; set; }
        public int CantidadDisponible { get; set; }
        public float ValorProducto { get; set; }
        public float IvaProducto { get; set; }
        public string ObservacionProducto { get; set; }
    }

    public class PedidoRequest
    {
        public string NombreRecibe { get; set; }
        public string ObservacionGeneral { get; set; }
        public int TotalProductos { get; set; }
        public int ValorTotalPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
    }

}
