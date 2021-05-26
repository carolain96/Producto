using Microsoft.EntityFrameworkCore;
using Productos.Models;

namespace Productos.Data
{
    public class ProductosContext : DbContext
    {
        internal readonly object Nombre;

        public DbSet<Producto> Productos { get; set; }
        public object Producto { get; internal set; }

        public ProductosContext(DbContextOptions dco) : base(dco) {

        }
    }
}