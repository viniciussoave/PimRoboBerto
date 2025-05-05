using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Aplicação.RespostaPadrao;
using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using System;

namespace Aplicação.Casos_de_Uso
{
    public class RegistrarMensagemUseCase : IRegistrarMensagemUseCase
    {
        private readonly IMensagemRepositorio _mensagemRepositorio;
        private readonly IChamadoRepositorio _chamadoRepositorio;

        public RegistrarMensagemUseCase(IMensagemRepositorio mensagemRepositorio, IChamadoRepositorio chamadoRepositorio)
        {
            _mensagemRepositorio = mensagemRepositorio;
            _chamadoRepositorio = chamadoRepositorio;
        }

        public RespostaPadrao<string> Executar(MensagemDTO mensagemDto)
        {
            try
            {
                var chamado = _chamadoRepositorio.ObterPorId(mensagemDto.ChamadoId);
                if (chamado == null)
                {
                    return RespostaPadrao<string>.Falha(false, "Registrar Mensagem", "Chamado não encontrado!");
                }

                var mensagem = Mensagem.CriarModelo(mensagemDto.UsuarioId, mensagemDto.Conteudo, mensagemDto.ChamadoId,mensagemDto.NumeroMensagem);
                _mensagemRepositorio.Adicionar(mensagem);

                return RespostaPadrao<string>.Sucesso(true, "Registrar Mensagem", "Mensagem registrada com sucesso!");
            }
            catch (Exception ex)
            {
                return RespostaPadrao<string>.Falha(false, "Registrar Mensagem", $"Erro ao registrar mensagem: {ex.Message}");
            }
        }
    }
}
