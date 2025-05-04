using Dominio.Entidades;
using System;

namespace Dominio.Interface_Repositorios
{
    public interface IMensagemRepositorio
    {
        void Adicionar(Mensagem mensagem);
        // Outros métodos relacionados a mensagens, se necessário
    }
}
