using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Chamado : ModeloAbstrato 
    {
        // Propriedades alinhadas com o banco (nomes em minúsculas)
        public Guid idservice { get; private set; }
        public string titulo { get; private set; }
        public string status { get; private set; }
        public int numerochamado { get; private set; }
        public DateTime dataatualizacao { get; private set; }
        public Guid idusuario { get; private set; }

        public List<Mensagem> mensagens { get; private set; } = new List<Mensagem>();

        // Construtor para criação manual (não persiste no banco)
        private Chamado(
            Guid idusuario,
            Guid idservice,
            string titulo,
            string status,
            int numerochamado) : base()
        {
            this.idusuario = idusuario;
            this.idservice = idservice;
            this.titulo = titulo;
            this.status = status;
            this.numerochamado = numerochamado;
            this.dataatualizacao = DateTime.UtcNow;
        }

        // Construtor para reconstrução do banco (já persistido)
        private Chamado(
            Guid id,
            Guid idservice,
            string titulo,
            string status,
            int numerochamado,
            DateTime datacriacao,
            DateTime dataatualizacao,
            Guid idusuario): base(id,datacriacao)
        {
            this.idservice = idservice;
            this.titulo = titulo;
            this.status = status;
            this.numerochamado = numerochamado;
            this.dataatualizacao = dataatualizacao;
            this.idusuario = idusuario;
        }
        public static Chamado CriarModelo(
            Guid idusuario,
            Guid idservice,
            string titulo,
            string status,
            int numerochamado)
        {
            return new Chamado(
                idusuario,
                idservice,
                titulo,
                status,
                numerochamado
            );
        }

        public static Chamado CriarModeloDoBanco(
            Guid id,
            Guid idservice,
            string titulo,
            string status,
            int numerochamado,
            DateTime datacriacao,
            DateTime dataatualizacao,
            Guid idusuario)
        {
            return new Chamado(
                id,
                idservice,
                titulo,
                status,
                numerochamado,
                datacriacao,
                dataatualizacao,
                idusuario
            );
        }


        public void AdicionarMensagem(Mensagem mensagem)
        {
            if (mensagem != null)
            {
                mensagens.Add(mensagem);
                dataatualizacao = DateTime.UtcNow; // Atualiza a data de atualização
            }
        }

        public override bool Validacao(out string erros)
        {
            erros = string.Empty;

            if (string.IsNullOrWhiteSpace(titulo))
                erros += "Título é obrigatório. ";

            if (string.IsNullOrWhiteSpace(status))
                erros += "Status é obrigatório. ";

            if (idusuario == Guid.Empty)
                erros += "Usuário inválido. ";

            return string.IsNullOrWhiteSpace(erros);
        }
    }
}