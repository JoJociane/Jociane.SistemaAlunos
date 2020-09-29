using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Jociane.SistemaAlunos.Util.Models
{
   public  class MateriaAluno
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public int AlunoId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Aluno Aluno { get; set; }

        public double Nota { get; set; }
    }
}
