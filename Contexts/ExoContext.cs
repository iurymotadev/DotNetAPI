using DotNetAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DotNetAPI.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        { }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=172.17.0.2,1433;Database=ExoApi;User Id=sa;Password=SenhaSQLserver123;");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}