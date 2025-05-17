using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Validacoes.Interface_Validacoes
{
    public interface IValidacoes
    {
        bool Validacao(out string erros);
    }
}

