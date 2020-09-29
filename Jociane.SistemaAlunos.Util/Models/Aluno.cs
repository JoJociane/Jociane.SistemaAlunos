using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Jociane.SistemaAlunos.Util.Models
{
    public class Aluno:Usuario
    {
        public DateTime DataNascimento { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public virtual ICollection<MateriaAluno> MateriaAlunos { get; set; } = new HashSet<MateriaAluno>();
    }
}
