
using Dominio.Dominio;
using System.Text.RegularExpressions;

namespace Dominio.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> EmailEstaOk(string email, string mensagem, string propriedadeNome)
        {
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[a-z]+$");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains(".") || !regex.IsMatch(email))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
