
using Dominio.Dominio;

namespace Dominio.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> EmailEstaOk(string email, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")|| !email.Contains("."))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
