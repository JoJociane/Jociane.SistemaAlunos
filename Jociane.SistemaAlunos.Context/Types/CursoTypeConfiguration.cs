using Jociane.SistemaAlunos.Util.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Context.Types
{
    public class CursoTypeConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            // curso tem muitos alunos
            builder.HasMany(q => q.Alunos).WithOne().HasForeignKey(q => q.CursoId); //uma maneira de referenciar a collection 1:n?

        }
    }
}
