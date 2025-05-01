using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Interfaces_Caso_De_Uso_e_Servicos
{
    public  interface ICodigoVerificacaoServico
    {
        public bool VerificarCodigo(string codigo, string entradaUsuario);
        public string GerarCodigo();
    }
}
