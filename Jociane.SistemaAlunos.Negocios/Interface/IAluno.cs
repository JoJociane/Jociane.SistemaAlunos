using Jociane.SistemaAlunos.Negocios.Result;
using Jociane.SistemaAlunos.Util.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Negocios.Interface
{
    public interface IAluno
    {

        //ControllerAluno-----------------------------
        Result<Aluno> ListarAlunos();
        Result<Aluno> CadastrarAluno();
        Result<Aluno> MatricularAluno(int idAluno, int idCurso); //relacionar AlunoeCurso
        Result<Aluno> MatricularAlunoEmMateria(int idAluno, int idMateria); //relacionar AlunoeMateria
        Result<MateriaAluno> AtribuirNotaEmMateria(int idAluno, int idMateria, double nota);//relaciona AlunoeMateria e atribui Nota
        Result<MateriaAluno> ListarNotaAluno(int idAluno);//busca todas as notas do Aluno

        //to do: AtualizarAluno, ExcluirAluno, CancelarMatriculaAluno, CancelarMatriculaemMateria, AtualizarNotaAluno, ExcluirNotaAluno
    }
}
