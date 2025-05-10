using Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Interface_Repositorios
{
    public interface IServicoRepositorio
    {
        List<Servico> ObterTodos();
    }
}
