using Jociane.SistemaAlunos.Util.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Context
{
    public class MeuBanquinhoContext : DbContext
    {
        public MeuBanquinhoContext()
        {

        }

        public MeuBanquinhoContext(DbContextOptions<MeuBanquinhoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04837\\SQLEXPRESS;Initial Catalog=MeuBanquinho;Integrated Security=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            //Definindo foreginKey muitos pra muitos
            modelBuilder.Entity<MateriaCurso>().HasKey(sc => new { sc.CursoId, sc.MateriaId });           
            modelBuilder.Entity<MateriaAluno>().HasKey(sc => new { sc.AlunoId, sc.MateriaId });

        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Administrador> Administradores { get; set; }

    }
}
