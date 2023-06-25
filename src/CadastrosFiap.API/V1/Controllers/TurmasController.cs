﻿using AutoMapper;
using CadastrosFiap.API.Controllers;
using CadastrosFiap.API.ViewModels;
using CadastrosFiap.Business.Interfaces;
using CadastrosFiap.Business.Models;
using CadastrosFiap.Business.Services;
using CadastrosFiap.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastrosFiap.API.V1.Controllers
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/turmas")]
    public class TurmasController : MainController
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly ITurmaService _turmaService;
        private readonly IMapper _mapper;

        public TurmasController(INotificador notificador, ITurmaRepository turmaRepository, IMapper mapper, ITurmaService turmaService) : base(notificador)
        {
            _turmaRepository = turmaRepository;
            _mapper = mapper;
            _turmaService = turmaService;
        }

        [HttpGet]
        public async Task<IEnumerable<TurmaViewModel>> ObterTurmas()
        {
            var turmas = _mapper.Map<IEnumerable<TurmaViewModel>>(await _turmaRepository.ObterTodos());
            return turmas;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TurmaViewModel>> ObterPorId(int id)
        {
            var turma = _mapper.Map<TurmaViewModel>(await _turmaRepository.ObterPorId(id));

            if (turma == null)
                return NotFound(); //404

            return turma;
        }

        [HttpPost]
        public async Task<ActionResult<TurmaViewModel>> Adicionar(TurmaViewModel turmaViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var turma = _mapper.Map<Turma>(turmaViewModel);
            await _turmaService.Adicionar(turma);

            return CustomResponse(turmaViewModel);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<TurmaViewModel>> Atualizar(int id, TurmaViewModel turmaViewModel)
        {
            if (id != turmaViewModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(turmaViewModel);
            }

            var turmaAtualizacao = _mapper.Map<TurmaViewModel>(await _turmaRepository.ObterPorId(id)); //captura a informção do banco e faz a atualização

            turmaViewModel.IdCurso = turmaAtualizacao.IdCurso;
            turmaAtualizacao.NomeTurma = turmaViewModel.NomeTurma;
            turmaAtualizacao.Ano = turmaViewModel.Ano;

            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var turma = _mapper.Map<Turma>(turmaViewModel);
            await _turmaService.Atualizar(_mapper.Map<Turma>(turmaAtualizacao));

            return CustomResponse(turmaViewModel);

        }

        //[ClaimsAuthorize("Admin", "Excluir")]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<TurmaViewModel>> Excluir(int id)
        {
            var TurmaViewModel = _mapper.Map<TurmaViewModel>(await _turmaRepository.ObterPorId(id));

            if (TurmaViewModel == null)
                return NotFound();

            await _turmaService.Remover(id);

            return CustomResponse();
        }
    }
}