using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao.Servicos
{
    public class ServicoPredefinidoFabrica
    {
        private readonly IServicoRepositorio _repositorio;

        public ServicoPredefinidoFabrica(IServicoRepositorio servicoRepositorio)
        {
            _repositorio = servicoRepositorio;
        }

        public List<Servico> ObterTodosComHierarquia()
        {
            var todos = _repositorio.ObterTodos();
            return todos.Select(servico => Servico.CriarModeloDoBanco(
                servico.Id,          // Passando o ID
                servico.DataCriacao, // Passando a DataCriacao
                servico.Nome,        // Passando o Nome
                servico.ServicoPaiId // Passando o ServicoPaiId
            )).ToList();
        }
    }
}
