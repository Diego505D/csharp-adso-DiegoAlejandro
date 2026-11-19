using Microsoft.EntityFrameworkCore;
using Reto.Models;
using Reto.Data;

namespace Reto.Data
{
    public class AgendaContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=agenda.db");
        }
    }
}