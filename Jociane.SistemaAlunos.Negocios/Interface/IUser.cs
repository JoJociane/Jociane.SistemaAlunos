using Jociane.SistemaAlunos.Negocios.Result;
using Jociane.SistemaAlunos.Util.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Negocios.Interface
{
    public interface IUser
    {
        //Metodos que serão implementados na classe, e serao chamados na CONTROLLER
        //CRUD para Aluno, Curso, Materia e Login

        //LoginController----------------------------
        void CriaAdministradorDefault();
        void CriaProfDefault();
        Result<Usuario> LogarUsuario(string login, string password);

        //to do: esqueciSenha
    }
}
