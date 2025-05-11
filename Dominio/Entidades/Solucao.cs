using System;

namespace Dominio.Entidades
{
    public class Solucao : ModeloAbstrato
    {
        public string Descricao { get; private set; }
        public Guid ServicoPaiId { get; private set; }

        public Solucao(string descricao, Guid servicoPaiId)
        {
            Descricao = descricao;
            ServicoPaiId = servicoPaiId;
        }

        public Solucao(Guid id, DateTime dataCriacao, string descricao, Guid servicoPaiId)
            : base(id, dataCriacao)
        {
            Descricao = descricao;
            ServicoPaiId = servicoPaiId;
        }

        public static Solucao CriarModelo(string descricao, Guid servicoPaiId)
        {
            return new Solucao(descricao, servicoPaiId);
        }

        public static Solucao CriarModeloDoBanco(Guid id, DateTime dataCriacao, string descricao, Guid servicoPaiId)
        {
            return new Solucao(id, dataCriacao, descricao, servicoPaiId);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";
            if (string.IsNullOrWhiteSpace(Descricao))
            {
                erros = "Descrição da solução é obrigatória.";
                return false;
            }

            return true;
        }
    }
}
