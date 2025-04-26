using Aplicação.DTOs;
using Aplicação.RespostaPadrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Interfaces_Caso_De_Uso
{
    public interface IRealizarLoginUseCase
    {
        public RespostaPadrao<string> Executar(LoginDTO usuarioDto);
    }
}
