using System;

namespace Dominio.Entidades
{
    public class Solucao : ModeloAbstrato
    {
        public string Descricao { get; private set; }
        public Guid ChamadoId { get; private set; }


        public Solucao(string descricao, Guid chamadoId)
        {
            Descricao = descricao;
            ChamadoId = chamadoId;
        }

        public Solucao(Guid id, DateTime dataCriacao, string descricao, Guid chamadoId)
            : base(id, dataCriacao)
        {
            Descricao = descricao;
            ChamadoId = chamadoId;
        }

        public static Solucao CriarModelo(string descricao, Guid chamadoId)
        {
            return new Solucao(descricao, chamadoId);
        }

        public static Solucao CriarModeloDoBanco(Guid id, DateTime dataCriacao, string descricao, Guid chamadoId)
        {
            return new Solucao(id, dataCriacao, descricao, chamadoId);
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
