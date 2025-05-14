using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Aplicação.RespostaPadrao;
using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using System.Threading.Tasks;

namespace Aplicação.Casos_de_Uso
{
    public class RecuperarSenhaUseCase : IRecuperarSenhaUseCase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ICodigoVerificacaoServico _codigoServico;

        public RecuperarSenhaUseCase(
            IUsuarioRepositorio usuarioRepositorio,
            ICodigoVerificacaoServico codigoServico)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _codigoServico = codigoServico;
        }

        public async Task<RespostaPadrao<Usuario>> Executar(string email)
        {
            // 1. Verifica se o email existe
            if (!_usuarioRepositorio.ExisteEmail(email))
            {
                return RespostaPadrao<Usuario>.Falha(false, "Email não cadastrado no sistema!", null);
            }

            // 2. Gera o código de verificação (que será a nova senha)
            string novaSenha = _codigoServico.GerarCodigo();

            // 3. Busca o usuário
            var usuario = _usuarioRepositorio.RecuperarPorEmail(email);

            // 4. Atualiza a senha no objeto usuário
            usuario.AlterarSenha(novaSenha);

            // 5. Atualiza no banco de dados
            bool sucesso = _usuarioRepositorio.AtualizarSenha(email, novaSenha);

            if (!sucesso)
            {
                return RespostaPadrao<Usuario>.Falha(false, "Falha ao atualizar a senha!", null);
            }

            // 6. Retorna o usuário com a senha atualizada
            return RespostaPadrao<Usuario>.Sucesso(true, "Nova senha gerada com sucesso.", usuario);
        }
    }
}