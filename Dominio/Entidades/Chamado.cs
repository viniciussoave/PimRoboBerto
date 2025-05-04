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
        public List<Mensagem> Mensagens { get; private set; } = new List<Mensagem>();

        // Construtor privado para evitar criação sem validação
        private Chamado(Guid id, DateTime dataCriacao, Guid usuarioId, Guid servicoId, string titulo, string status) : base(id, dataCriacao)
        {
            UsuarioId = usuarioId;
            ServicoId = servicoId;
            Titulo = titulo;
            Status = status;
        }
        public Chamado(Guid usuarioId, Guid servicoId, string titulo, string status)
        {
            UsuarioId = usuarioId;
            ServicoId = servicoId;
            Titulo = titulo;
            Status = status;
        }

        // Método para adicionar uma mensagem ao chamado
        public void AdicionarMensagem(Mensagem mensagem)
        {
            if (mensagem != null)
            {
                Mensagens.Add(mensagem);
            }
        }
        // Método de validação, que poderia verificar mais regras de negócio
        public override bool Validacao(out string erros)
        {
            erros = string.Empty;
            if (string.IsNullOrWhiteSpace(Titulo))
            {
                erros += "O título do chamado não pode estar vazio. ";
            }

            if (string.IsNullOrWhiteSpace(Status))
            {
                erros += "O status do chamado não pode estar vazio. ";
            }

            // Pode adicionar mais validações conforme necessário

            return string.IsNullOrWhiteSpace(erros);
        }
        public static Chamado CriarModelo(Guid usuarioId, Guid servicoId, string titulo, string status)
        {
            return new Chamado(usuarioId, servicoId, titulo, status);
        }
        public static Chamado CriarModeloDoBanco(Guid id, DateTime dataCriacao, Guid usuarioId, Guid servicoId, string titulo, string status)
        {
            return new Chamado(id, dataCriacao, usuarioId, servicoId, titulo, status);
        }
    }
}
