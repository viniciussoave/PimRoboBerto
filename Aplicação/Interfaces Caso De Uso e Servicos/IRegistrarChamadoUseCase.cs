using Aplicação.RespostaPadrao;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface_Repositorios
{
    internal interface IRegistrarChamadoUseCase
    {
        public RespostaPadrao<Chamado> Executar(Guid usuarioId, Guid servicoId, string titulo, string status);
    }
}
