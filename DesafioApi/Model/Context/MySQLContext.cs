using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DesafioApi.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions <MySQLContext> options) : base(options)
        {
        }

        public DbSet<Escola> Escolas { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Turma> Turmas { get; set; }

    }
}
