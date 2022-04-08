using Super.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Super.Database
{
    public class TiendaContext : DbContext

    {
        public TiendaContext() : base("Super")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        DbSet<Cliente> clientes { get;set; }
        DbSet<Producto> productos { get;set; }
        DbSet<ClasificacionCliente> clasificacionClientes { get;set; }
        DbSet<ClasificacionProducto> clasificacionProductos { get;set; }
        DbSet<Pedido> pedidos { get; set; }
        DbSet<PedidoDetalle> pedidoDetalles { get; set; }
        DbSet<Unidad> unidads { get; set; }





    }
}