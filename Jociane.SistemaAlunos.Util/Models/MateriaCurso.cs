using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Util.Models
{
    public class MateriaCurso
    {
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
