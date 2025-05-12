using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface_InfraEstrutura
{
    public interface IEnviarEmailServico
    {
        public Task<bool> EnviarEmail(string destinatario, string assunto, string corpo);
    }
}
