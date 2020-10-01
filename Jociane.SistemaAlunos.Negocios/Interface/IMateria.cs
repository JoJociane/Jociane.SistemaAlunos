using Jociane.SistemaAlunos.Negocios.Result;
using Jociane.SistemaAlunos.Util.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jociane.SistemaAlunos.Negocios.Interface
{
    public interface IMateria
    {
        //MateriaController-------------------------
        Result<Materia> ListarMaterias();
        Result<Materia> CadastrarMateria(Materia materia);
        Result<Materia> UpdateMateria(int id, Materia matAtualizada);
        Result<Materia> DeleteMateria(int id);

        //to do: 

    }
}
