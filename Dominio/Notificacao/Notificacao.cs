using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dominio
{
    public class Notificacao
    {
        public string Mensagem { get; private set; }
        public string NomePropriedade { get; private set; }
        public Notificacao(string mensagem, string nomePropriedade)
        {
            Mensagem = mensagem;
            NomePropriedade = nomePropriedade;
        }
    }}

