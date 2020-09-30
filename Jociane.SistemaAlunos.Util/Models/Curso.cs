using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Jociane.SistemaAlunos.Util.Models
{
    public class Curso:GenericClass
    {

        [JsonIgnore]
        [IgnoreDataMember]
        public ICollection<Aluno> Alunos { get; set; } = new HashSet<Aluno>();

        public virtual ICollection<MateriaCurso> MateriaCurso { get; set; } = new HashSet<MateriaCurso>();
    }
}
