using Aplicação.RespostaPadrao;
using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using System;

namespace Aplicacao.CasosDeUso
{
    public class RegistrarChamadoUseCase : IRegistrarChamadoUseCase
    {
        private readonly IChamadoRepositorio _chamadoRepositorio;
        private readonly UsuarioContexto _usuarioContexto;

        public RegistrarChamadoUseCase(IChamadoRepositorio chamadoRepositorio, UsuarioContexto usuarioContexto)
        {
            _chamadoRepositorio = chamadoRepositorio;
            _usuarioContexto = usuarioContexto;
        }

        public RespostaPadrao<Chamado> Executar(Guid servicoId, string titulo, string status)
        {
            string numeroChamado = GerarNumeroChamado();

            var usuarioId = _usuarioContexto.ObterUsuario();

            var chamado = Chamado.CriarModelo(usuarioId.Id, servicoId, titulo, status, Convert.ToInt32(numeroChamado));

            if (!chamado.Validacao(out string erros))
            {
                return RespostaPadrao<Chamado>.Falha(false, "Chamado");
            }

            _chamadoRepositorio.Adicionar(chamado);

            return RespostaPadrao<Chamado>.Sucesso(true, "Chamado", chamado);
        }

        private string GerarNumeroChamado()
        {
            var ultimoChamado = _chamadoRepositorio.ObterUltimoNumeroChamado();
            int proximoNumero = ultimoChamado.HasValue ? ultimoChamado.Value + 1 : 1;
            return proximoNumero.ToString("D4"); // <-- gera 0001, 0002, etc.
        }


    }
}
