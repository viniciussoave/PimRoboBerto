using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Aplicação.RespostaPadrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Casos_de_Uso
{
    public class ConfirmarCodigoVerificacaoUseCase : IConfirmarCodigoVerificacaoUseCase
    {
        private readonly ICodigoVerificacaoServico _codigoVerificacaoServico;

        public ConfirmarCodigoVerificacaoUseCase(ICodigoVerificacaoServico codigoVerificacaoServico)
        {
            _codigoVerificacaoServico = codigoVerificacaoServico;
        }

        public RespostaPadrao<string> Executar(string codigo, string entradaUsuario)
        {
           
           var codigoCorreto = _codigoVerificacaoServico.VerificarCodigo(codigo, entradaUsuario);

            if (!codigoCorreto)
            {
                return RespostaPadrao<string>.Falha(false, "Aviso","Codigo incorreto!");
            }


            return RespostaPadrao<string>.Sucesso(true, "Aviso", "Código correto!");
        }
    }
}
