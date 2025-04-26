using Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public abstract class ModeloAbstrato
    {
        public Guid Id { get;  set; }
        public DateTime DataCriacao { get;  set; }

        private List<Notificacao> listaNotificacoes = new List<Notificacao>();

        public ModeloAbstrato()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }
        public ModeloAbstrato(Guid id, DateTime dataCriacao)
        {
            Id = id;
            DataCriacao = dataCriacao;
        }

        public IReadOnlyCollection<Notificacao> Notificacoes => listaNotificacoes;
        protected void SetNotificacoesLista(List<Notificacao> notificacoes)
        {
            listaNotificacoes = notificacoes;
        }
        public abstract bool Validacao(out string erros);
    }
}
