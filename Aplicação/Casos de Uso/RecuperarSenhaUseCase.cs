using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Aplicação.RespostaPadrao;
using Dominio.Interface_InfraEstrutura;
using Dominio.Interface_Repositorios;
using System.Threading.Tasks;

namespace Aplicação.Casos_de_Uso
{
    public class RecuperarSenhaUseCase : IRecuperarSenhaUseCase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IEnviarEmailServico _enviarEmailServico;
        private readonly ICodigoVerificacaoServico _codigoVerificacaoServico;

        public RecuperarSenhaUseCase(
            IUsuarioRepositorio usuarioRepositorio,
            IEnviarEmailServico enviarEmailServico,
            ICodigoVerificacaoServico codigoVerificacaoServico)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _enviarEmailServico = enviarEmailServico;
            _codigoVerificacaoServico = codigoVerificacaoServico;
        }

        public async Task<(RespostaPadrao<string>, string codigoVerificacao)> Executar(string email)
        {
            // 1. Validação de domínio
            if (!_usuarioRepositorio.ExisteEmail(email))
            {
                return (RespostaPadrao<string>.Falha(
                    procede: false,
                    mensagem: "Email não cadastrado no sistema",
                    dados: "Registro de usuário"),
                    string.Empty);
            }

            // 2. Geração do código
            var codigoVerificacao = _codigoVerificacaoServico.GerarCodigo();

            // 3. Envio de email
            var assunto = "Código de Verificação - Recuperação de Senha";
            var corpo = $"Seu código de verificação é: {codigoVerificacao}";

            bool emailEnviado = await _enviarEmailServico.EnviarEmail(
                destinatario: email,
                assunto: assunto,
                corpo: corpo);

            if (!emailEnviado)
            {
                return (RespostaPadrao<string>.Falha(
                    procede: false,
                    mensagem: "Falha ao enviar código de verificação",
                    dados: "Serviço de Email"),
                    string.Empty);
            }

            // 4. Retorno de sucesso
            return (RespostaPadrao<string>.Sucesso(
                procede: true,
                mensagem: "Código de verificação enviado com sucesso",
                dados: "Recuperação de Senha"),
                codigoVerificacao);
        }
    }
}