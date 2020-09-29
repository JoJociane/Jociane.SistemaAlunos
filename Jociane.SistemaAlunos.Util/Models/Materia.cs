using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Jociane.SistemaAlunos.Util.Models
{
    public class Materia:GenericClass
    {
        public DateTime DataCadastro { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<MateriaAluno> MateriaAlunos { get; set; } = new HashSet<MateriaAluno>();

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<MateriaCurso> Cursos { get; set; } = new HashSet<MateriaCurso>();


        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

    }
}
