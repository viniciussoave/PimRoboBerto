using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Chamado : ModeloAbstrato
    {
        public Guid UsuarioId { get; private set; }
        public Guid ServicoId { get; private set; }
        public string Titulo { get; private set; }
        public string Status { get; private set; }
        public int NumeroChamado { get; private set; }

        public List<Mensagem> Mensagens { get; private set; } = new List<Mensagem>();

        private Chamado(Guid id, DateTime dataCriacao, Guid usuarioId, Guid servicoId, string titulo, string status, int numeroChamado)
            : base(id, dataCriacao)
        {
            UsuarioId = usuarioId;
            ServicoId = servicoId;
            Titulo = titulo;
            Status = status;
            NumeroChamado = numeroChamado;
        }

        private Chamado(Guid usuarioId, Guid servicoId, string titulo, string status, int numeroChamado)
        {
            UsuarioId = usuarioId;
            ServicoId = servicoId;
            Titulo = titulo;
            Status = status;
            NumeroChamado = numeroChamado;
        }

        public void AdicionarMensagem(Mensagem mensagem)
        {
            if (mensagem != null)
            {
                Mensagens.Add(mensagem);
            }
        }

        public override bool Validacao(out string erros)
        {
            erros = string.Empty;

            if (string.IsNullOrWhiteSpace(Titulo))
                erros += "O título do chamado não pode estar vazio. ";

            if (string.IsNullOrWhiteSpace(Status))
                erros += "O status do chamado não pode estar vazio. ";

            return string.IsNullOrWhiteSpace(erros);
        }

        public static Chamado CriarModelo(Guid usuarioId, Guid servicoId, string titulo, string status, int numeroChamado)
        {
            return new Chamado(usuarioId, servicoId, titulo, status, numeroChamado);
        }

        public static Chamado CriarModeloDoBanco(Guid id, DateTime dataCriacao, Guid usuarioId, Guid servicoId, string titulo, string status, int numeroChamado)
        {
            return new Chamado(id, dataCriacao, usuarioId, servicoId, titulo, status, numeroChamado);
        }
    }
}
