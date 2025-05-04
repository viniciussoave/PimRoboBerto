using Dominio.Validacoes;
using Dominio.Validacoes.Interface_Validacoes;
using System;

namespace Dominio.Entidades
{
    public class Mensagem : ModeloAbstrato, IContrato
    {
        public string Conteudo { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Guid ChamadoId { get; private set; }

        private Mensagem(string conteudo, Guid usuarioId, Guid chamadoId) : base()
        {
            Conteudo = conteudo;
            UsuarioId = usuarioId;
            ChamadoId = chamadoId;
        }

        // Construtor usado para reconstrução vinda do banco
        public Mensagem(Guid id, DateTime dataCriacao, string conteudo, Guid usuarioId, Guid chamadoId)
            : base(id, dataCriacao)
        {
            Conteudo = conteudo;
            UsuarioId = usuarioId;
            ChamadoId = chamadoId;
        }

        public static Mensagem CriarModelo(string conteudo, Guid usuarioId, Guid chamadoId)
        {
            return new Mensagem(conteudo, usuarioId, chamadoId);
        }

        public static Mensagem CriarModeloDoBanco(Guid id, DateTime dataCriacao, string conteudo, Guid usuarioId, Guid chamadoId)
        {
            return new Mensagem(id, dataCriacao, conteudo, usuarioId, chamadoId);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";

            var contratos = new ContratoValidacoes<Mensagem>()
                .TextoEstaOk(Conteudo, 1, 1000, "A mensagem deve conter entre 1 e 1000 caracteres.", "Conteudo");

            if (!contratos.EhValido())
            {
                erros = contratos.CapturadorErros();
                return false;
            }

            return true;
        }
    }
}
