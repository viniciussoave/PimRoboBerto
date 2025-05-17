using Aplicação.DTOs;
using Aplicação.RespostaPadrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Interfaces_Caso_De_Uso
{
    public interface IRegistrarUsuarioUseCase
    {
        public RespostaPadrao<string> Executar(UsuarioDTO usuarioDto, Func<global::Moq.Times> once);
    }
}
