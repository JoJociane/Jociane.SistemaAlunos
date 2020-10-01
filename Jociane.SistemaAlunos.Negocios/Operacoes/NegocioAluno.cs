using Jociane.SistemaAlunos.Context;
using Jociane.SistemaAlunos.Negocios.Interface;
using Jociane.SistemaAlunos.Negocios.Result;
using Jociane.SistemaAlunos.Util.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Negocios.Operacoes
{
    public class NegocioAluno : IAluno
    {
        private readonly MeuBanquinhoContext db;

        public NegocioAluno(MeuBanquinhoContext banco)
        {
            db = banco;
        }

        public Result<Aluno> CadastrarAluno()
        {
            //
            throw new NotImplementedException();
        }

        public Result<Aluno> ListarAlunos()
        {
            throw new NotImplementedException();
        }

        public Result<MateriaAluno> ListarNotaAluno(int idAluno)
        {
            throw new NotImplementedException();
        }

        public Result<Aluno> MatricularAluno(int idAluno, int idCurso)
        {
            throw new NotImplementedException();
        }

        public Result<Aluno> MatricularAlunoEmMateria(int idAluno, int idMateria)
        {
            throw new NotImplementedException();
        }
        public Result<MateriaAluno> AtribuirNotaEmMateria(int idAluno, int idMateria, double nota)
        {
            throw new NotImplementedException();
        }
    }

}
