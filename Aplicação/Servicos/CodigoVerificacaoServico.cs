using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Servicos
{
    public class CodigoVerificacaoServico : ICodigoVerificacaoServico
    {

        public string GerarCodigo()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }

    }
}
