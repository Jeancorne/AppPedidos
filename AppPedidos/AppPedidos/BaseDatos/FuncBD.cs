using AppPedidos.BaseDatos.clsModelos;
using AppPedidos.BaseDatos.Tablas;
using AppPedidos.Modelos.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPedidos.BaseDatos
{
    public class FuncBD
    {
        public async Task<string> IngresarBD([FromBody]ClienteRequest clien)
        {
            try
            {
                using (var context = new AppAplicationDbContext())
                {
                    var cliente = new tblCliente();
                    cliente.NombreCliente = clien.NombreCliente;
                    cliente.ApellidoCliente = clien.ApellidoCliente;
                    cliente.CedulaCliente = clien.CedulaCliente;
                    cliente.EmailCliente = clien.EmailCliente;
                    cliente.TelefonoCliente = clien.TelefonoCliente;
                    cliente.DireccionCliente = clien.DireccionCliente;
                    cliente.Ciudad = clien.Ciudad;
                    context.tblClientes.Add(cliente);
                    var result = await context.SaveChangesAsync();
                    if (result > 0)
                    {
                        return "Registrado Correctamente.";
                    }
                    else
                    {
                        return "No se pudo Registrar.";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<List<tblProducto>> FiltrarProductos([FromBody]FiltrarProducto filtro)
        {
            try
            {
                await using (var context = new AppAplicationDbContext())
                {
                    var tblProducto = context.tblProducto.Where(x => x.IdProducto == Convert.ToInt32(filtro.Filtro)
                                                                 || x.PluProducto == Convert.ToInt32(filtro.Filtro)
                                                                 || x.NombreProducto == Convert.ToString(filtro.Filtro)).ToList();
                    return tblProducto;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<bool> RegistrarProducto([FromBody]ProductoRequest produ)
        {
            try
            {
                using (var context = new AppAplicationDbContext())
                {
                    var producto = new tblProducto();
                    producto.PluProducto = produ.PluProducto;
                    producto.NombreProducto = produ.NombreProducto;
                    producto.DescripcionProducto = produ.DescripcionProducto;
                    producto.MarcaProducto = produ.MarcaProducto;
                    producto.CantidadDisponible = produ.CantidadDisponible;
                    producto.ValorProducto = produ.ValorProducto;
                    producto.IvaProducto = produ.IvaProducto;
                    producto.ObservacionProducto = produ.ObservacionProducto;

                    context.tblProducto.Add(producto);
                    var result = await context.SaveChangesAsync();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> RegistrarPedido([FromBody]PedidoRequest pedi)
        {
            try
            {
                using (var context = new AppAplicationDbContext())
                {
                    var pedido = new tblPedido();
                    pedido.NombreRecibe = pedi.NombreRecibe;
                    pedido.ObservacionGeneral = pedi.ObservacionGeneral;
                    pedido.TotalProductos = pedi.TotalProductos;
                    pedido.ValorTotalPedido = pedi.ValorTotalPedido;
                    pedido.IdCliente = pedi.IdCliente;
                    pedido.IdProducto = pedi.IdProducto;
                    context.tblPedido.Add(pedido);
                    var result = await context.SaveChangesAsync();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
