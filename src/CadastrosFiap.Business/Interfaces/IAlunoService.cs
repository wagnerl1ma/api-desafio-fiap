﻿using CadastrosFiap.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrosFiap.Business.Interfaces
{
    public interface IAlunoService
    {
        Task<bool> Adicionar(Aluno aluno);
        Task<bool> Atualizar(Aluno aluno);
        Task Remover(int id);
    }
}
