using QualaNet.Models;
using Microsoft.EntityFrameworkCore;

namespace QualaNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<QualaSucursales> Sucursales { get; set; }
    }
}
