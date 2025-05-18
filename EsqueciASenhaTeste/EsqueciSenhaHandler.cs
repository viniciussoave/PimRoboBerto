using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;

namespace EsqueciASenhaTeste
{
    internal class EsqueciSenhaHandler
    {
        private IRecuperarSenhaUseCase @object;

        public EsqueciSenhaHandler(IRecuperarSenhaUseCase @object)
        {
            this.@object = @object;
        }

        internal async Task EnviarConfirmacaoAsync(string v)
        {
            throw new NotImplementedException();
        }
    }
}