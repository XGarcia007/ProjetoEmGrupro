using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Testeprojeto.Models;

namespace Testeprojeto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Servicos> Servicos { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Aqui, nos dizemos como ira se chamar a tabela no banco de dados
            base.OnModelCreating(builder);
            builder.Entity<Contato>().ToTable("Contatos");
            builder.Entity<Portfolio>().ToTable("Portfolios");
            builder.Entity<Servicos>().ToTable("Servicos");
            //Depois que voce cria, você pode adicionar ao banco de dados 
            //Utilizando as migrations do Entity Framework
        }
    }
}
