
using Microsoft.EntityFrameworkCore;
using PrejetoPortifolio1.models;

namespace Mecanica.api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        

        public DbSet<Aluno> alunos { get; set; }

        public DbSet<Projeto> projetos { get; set; }

        public DbSet<Turma> turmas { get; set; }
    }
}
