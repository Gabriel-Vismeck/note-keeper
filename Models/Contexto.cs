using Microsoft.EntityFrameworkCore;

namespace gerenciador_de_notas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Nota> Nota { get; set; }
    }
}
