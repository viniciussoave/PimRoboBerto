
using Dominio.Dominio;

namespace Dominio.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> NomeEstaOk(string nome, short minLength, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrEmpty(nome) || (nome.Length < minLength))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
