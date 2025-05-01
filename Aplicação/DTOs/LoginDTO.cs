using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.DTOs
{
    public class LoginDTO
    {

        public string Usuario { get; set; }
        public string Senha { get; set; }
        public CodigoVerificacaoDTO codigoVerificacaoDTO { get; set; }

        public LoginDTO()
        {
        }
    }
}
