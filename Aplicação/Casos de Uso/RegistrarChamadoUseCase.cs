
using Aplicação.RespostaPadrao;
using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using System;

namespace Aplicacao.CasosDeUso
{
    public class RegistrarChamadoUseCase : IRegistrarChamadoUseCase
    {
        private readonly IChamadoRepositorio _chamadoRepositorio;

        public RegistrarChamadoUseCase(IChamadoRepositorio chamadoRepositorio)
        {
            _chamadoRepositorio = chamadoRepositorio;
        }

        public RespostaPadrao<Chamado> Executar(Guid usuarioId, Guid servicoId, string titulo, string status)
        {
            var chamado = Chamado.CriarModelo(usuarioId, servicoId, titulo, status);

            if (!chamado.Validacao(out string erros))
            {
                return RespostaPadrao<Chamado>.Falha(false, "Chamado");
            }

            _chamadoRepositorio.Adicionar(chamado);

            return RespostaPadrao<Chamado>.Sucesso(true, "Chamado", chamado);
        }

    }
}
