using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Util.Models
{
   public  class Professor:Usuario
    {
        public ICollection<Materia> Materia { get; set; } = new HashSet<Materia>();
    }
}
