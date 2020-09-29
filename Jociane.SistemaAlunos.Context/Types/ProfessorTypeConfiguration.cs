using Jociane.SistemaAlunos.Util.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Context.Types
{
    public class ProfessorTypeConfiguration : IEntityTypeConfiguration<Professor>
    {

        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Sobrenome).IsRequired().HasMaxLength(80);
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(16);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(12);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(20);

            builder.HasMany(q => q.Materia).WithOne().HasForeignKey(q => q.ProfessorId);
        }
    }
}
