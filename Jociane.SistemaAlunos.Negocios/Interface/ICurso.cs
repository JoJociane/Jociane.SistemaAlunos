using Jociane.SistemaAlunos.Negocios.Result;
using Jociane.SistemaAlunos.Util.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Negocios.Interface
{
    public interface ICurso
    {
        //CursoController-----------------------------
        Result<Curso> ListarCursos();
        Result<Curso> CadastrarCurso(Curso curso);
        Result<Curso> Add_Mat_em_Curso(string nomeCurso, string nomeMateria);//relacionar MateriaCurso

        //to do: AtualizarCurso, ExcluirCurso, AtualizarRelacaoMateria, RemoverRelacao
    }
}
