using Dominio.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Dominio.Interface_Repositorios
{
    public interface IChamadoRepositorio
    {
        void Adicionar(Chamado chamado);
        List<Chamado> ObterPorUsuario(Guid idusuario);
        int? ObterUltimoNumeroChamado();
        Chamado ObterPorId(Guid id);

    }
}