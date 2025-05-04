using Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Interface_Repositorios
{
    public interface IMensagemRepositorio
    {
        void Adicionar(Mensagem mensagem);
        List<Mensagem> ObterPorChamado(Guid chamadoId);
    }
}
