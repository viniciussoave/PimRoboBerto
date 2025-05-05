using Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Interface_Repositorios
{
    public interface IChamadoRepositorio
    {
        void Adicionar(Chamado chamado);
        List<Chamado> ObterPorUsuario(Guid usuarioId);
        Chamado ObterPorId(Guid id);
        public int? ObterUltimoNumeroChamado();
    }
}
