using Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Interface_Repositorios
{
    public interface ISolucaoRepositorio
    {
        void Inserir(Solucao solucao);
        List<Solucao> ObterPorServicoPai(Guid servicoPaiId);
    }
}
