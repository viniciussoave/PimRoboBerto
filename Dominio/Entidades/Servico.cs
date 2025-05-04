using Dominio.Validacoes;
using Dominio.Validacoes.Interface_Validacoes;
using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Servico : ModeloAbstrato, IContrato
    {
        public string Nome { get; private set; }
        public Guid? ServicoPaiId { get; private set; }

        private readonly List<Servico> _filhos = new();
        public IReadOnlyCollection<Servico> Filhos => _filhos.AsReadOnly();

        // Construtor principal para uso do domínio
        private Servico(string nome, Guid? servicoPaiId = null) : base()
        {
            Nome = nome;
            ServicoPaiId = servicoPaiId;
        }

        // Construtor usado ao reconstruir do banco
        public Servico(Guid id, DateTime dataCriacao, string nome, Guid? servicoPaiId) : base(id, dataCriacao)
        {
            Nome = nome;
            ServicoPaiId = servicoPaiId;
        }

        public static Servico CriarModelo(string nome, Guid? servicoPaiId = null)
        {
            return new Servico(nome, servicoPaiId);
        }

        public static Servico CriarModeloDoBanco(Guid id, DateTime dataCriacao, string nome, Guid? servicoPaiId)
        {
            return new Servico(id, dataCriacao, nome, servicoPaiId);
        }

        public void AdicionarFilho(Servico filho)
        {
            _filhos.Add(filho);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";

            var contratos = new ContratoValidacoes<Servico>()
                .NomeEstaOk(Nome, 3, "Nome inválido. Deve conter pelo menos 3 caracteres.", "Nome");

            if (!contratos.EhValido())
            {
                erros = contratos.CapturadorErros();
                return false;
            }

            return true;
        }
    }
}
