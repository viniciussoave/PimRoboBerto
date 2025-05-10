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
            int numeroChamado = GerarNumeroChamado();

            var chamado = Chamado.CriarModelo(usuarioId, servicoId, titulo, status, numeroChamado);

            if (!chamado.Validacao(out string erros))
            {
                return RespostaPadrao<Chamado>.Falha(false, "Chamado");
            }

            _chamadoRepositorio.Adicionar(chamado);

            return RespostaPadrao<Chamado>.Sucesso(true, "Chamado", chamado);
        }

        private int GerarNumeroChamado()
        {
    
            var ultimoChamado = _chamadoRepositorio.ObterUltimoNumeroChamado();
            if (ultimoChamado.HasValue)
            {
                return ultimoChamado.Value + 1;
            }
            return 1;  
        }
    }
}
