using AppPedidos.BaseDatos.clsModelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPedidos.BaseDatos.Tablas
{
    class AppAplicationDbContext : DbContext
    {       
     
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Data Source=NODEJS;Initial Catalog=dbsistema_domicilios;Integrated Security=True");
        public DbSet<tblCliente> tblClientes { get; set; }
        public DbSet<tblProducto> tblProducto { get; set; }
        public DbSet<tblPedido> tblPedido { get; set; }
    }
}
