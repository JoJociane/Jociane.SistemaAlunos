using Jociane.SistemaAlunos.Util.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Util.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string  Senha { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string CPF { get; set; }
    }
}
