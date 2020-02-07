using AppPedidos.BaseDatos;
using AppPedidos.BaseDatos.clsModelos;
using AppPedidos.Modelos.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPedidos.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class clsCRUD : ControllerBase
    {
       
        [HttpPost("RegistrarCliente")]
        public async Task<ActionResult<string>> RegistrarCliente([FromBody]ClienteRequest clien)
        {
            try
            {
                FuncBD func = new FuncBD();
                string val = await func.IngresarBD(clien);
                return val;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        [HttpPost("FiltrarProducto")]
        public async Task<ActionResult<List<tblProducto>>> FiltrarProducto([FromBody]FiltrarProducto filtro)
        {
            try
            {
                FuncBD func = new FuncBD();
                List<tblProducto> product = await func.FiltrarProductos(filtro);
                return product;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost("RegistrarProducto")]
        public async Task<ActionResult<bool>> RegistrarProducto([FromBody]ProductoRequest produ)
        {
            try
            {
                FuncBD func = new FuncBD();
                bool res = await func.RegistrarProducto(produ);
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpPost("RegistrarPedido")]
        public async Task<ActionResult<bool>> RegistrarPedido([FromBody]PedidoRequest pedido)
        {
            try
            {
                FuncBD func = new FuncBD();
                bool res = await func.RegistrarPedido(pedido);
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
