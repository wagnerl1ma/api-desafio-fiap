﻿using CadastrosFiap.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrosFiap.Business.Interfaces
{
    public interface IAlunoTurmaRepository : IRepository<AlunoTurma>
    {
        Task<bool> ExisteIdAlunoTurma(int id);
        Task<AlunoTurma> ObterIdAlunoTurma(int id);
    }
}
