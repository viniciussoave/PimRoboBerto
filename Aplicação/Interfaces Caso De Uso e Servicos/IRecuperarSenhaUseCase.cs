using Aplicação.RespostaPadrao;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Interfaces_Caso_De_Uso_e_Servicos
{
    public interface IRecuperarSenhaUseCase
    {
        public  Task<RespostaPadrao<Usuario>> Executar(string email);
      }
}
