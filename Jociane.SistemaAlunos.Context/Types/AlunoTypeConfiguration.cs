using Jociane.SistemaAlunos.Util.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Context.Types
{
    public class AlunoTypeConfiguration : IEntityTypeConfiguration<Aluno>
    {
       
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Sobrenome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(16);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(12);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(20);
            //aluno tem um curso, com a fk cursoid
            builder.HasOne(x => x.Curso).WithMany().HasForeignKey(x => x.CursoId);//mudei b=>b.Alunos
        }
    }
}
