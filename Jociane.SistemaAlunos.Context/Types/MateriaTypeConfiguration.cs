using Jociane.SistemaAlunos.Util.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Context.Types
{
    public class MateriaTypeConfiguration : IEntityTypeConfiguration<Materia>
    {
        
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(80);

            builder.HasOne(x => x.Professor).WithMany().HasForeignKey(x => x.ProfessorId);
        }
    }
}
