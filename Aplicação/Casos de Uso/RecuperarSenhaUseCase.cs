using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Aplicação.RespostaPadrao;
using Aplicação.Servicos;
using Dominio.Interface_Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Casos_de_Uso
{
    public class RecuperarSenhaUseCase : IRecuperarSenhaUseCase
    {
        string emailOrigem  = "douglas.engratulis@aluno.unip.br";
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IEnviarEmailServico _enviarEmailServico;
        private readonly ICodigoVerificacaoEmail _codigoVerificacaoEmail;

        public RecuperarSenhaUseCase(IUsuarioRepositorio usuarioRepositorio, IEnviarEmailServico enviarEmailServico, ICodigoVerificacaoEmail codigoVerificacaoEmail)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _enviarEmailServico = enviarEmailServico;
            _codigoVerificacaoEmail = codigoVerificacaoEmail;
        }

         public async Task<RespostaPadrao<string>> Executar(string email)
        {
            if (!_usuarioRepositorio.ExisteEmail(email))
            {
                // return;
            }

            var codigoVerificacao = _codigoVerificacaoEmail.GerarCodigo();

            bool resposta = await _enviarEmailServico.EnviarEmail(email, emailOrigem, $"Seu código de recuperação é: {codigoVerificacao}", "Codigo verificação");

            
            return RespostaPadrao<string>.Sucesso(true, "Recuperação email", "Enviado código de verificação!");

        }

    }
}
