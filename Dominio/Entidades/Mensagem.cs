using System;

namespace Dominio.Entidades
{
    public class Mensagem : ModeloAbstrato
    {
        public Guid UsuarioId { get; private set; }
        public Guid ChamadoId { get; private set; }
        public string Conteudo { get; private set; }
        public int NumMensagem { get; private set; } 

        private Mensagem(Guid usuarioId, Guid chamadoId, string conteudo, int numMensagem)
            : base()
        {
            UsuarioId = usuarioId;
            ChamadoId = chamadoId;
            Conteudo = conteudo;
            NumMensagem = numMensagem;
        }

        public Mensagem(Guid id, DateTime dataCriacao, Guid usuarioId, Guid chamadoId, string conteudo, int numMensagem)
            : base(id, dataCriacao)
        {
            UsuarioId = usuarioId;
            ChamadoId = chamadoId;
            Conteudo = conteudo;
            NumMensagem = numMensagem;
        }

        public static Mensagem CriarModelo(Guid usuarioId, string conteudo, Guid chamadoId, int numeroMensagem)

        {
            return new Mensagem(usuarioId, chamadoId, conteudo, numeroMensagem);
        }

        public static Mensagem CriarModeloDoBanco(Guid id, DateTime dataCriacao, Guid usuarioId, Guid chamadoId, string conteudo, int numMensagem)
        {
            return new Mensagem(id, dataCriacao, usuarioId, chamadoId, conteudo, numMensagem);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";

            if (string.IsNullOrWhiteSpace(Conteudo))
            {
                erros = "Conteúdo da mensagem não pode estar vazio.";
                return false;
            }

            if (NumMensagem <= 0)
            {
                erros = "Número da mensagem deve ser maior que zero.";
                return false;
            }

            return true;
        }
    }
}
