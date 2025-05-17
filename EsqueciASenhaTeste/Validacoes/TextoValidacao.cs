
using Dominio.Dominio;

namespace Dominio.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> TextoEstaOk(string nome, short minLength, short maxLength, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrEmpty(nome) || (nome.Length < minLength) || (nome.Length > maxLength))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
