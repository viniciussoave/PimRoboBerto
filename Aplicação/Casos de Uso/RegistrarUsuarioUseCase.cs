using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using Aplicação.RespostaPadrao;
using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Casos_de_Uso
{
    public class RegistrarUsuarioUseCase : IRegistrarUsuarioUseCase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public RegistrarUsuarioUseCase(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public RespostaPadrao<string> Executar(UsuarioDTO usuarioDto)
        {
            var usuario = Usuario.CriarModelo(usuarioDto.Nome, usuarioDto.Senha, usuarioDto.Email);

            if (_usuarioRepositorio.ExisteEmail(usuarioDto.Email))
            {
                return RespostaPadrao<string>.Falha(false, "Registro de usuário", "Email já cadastrado no sistema!");
            }
            if (_usuarioRepositorio.NomeUsuarioExiste(usuarioDto.Nome))
            {
                return RespostaPadrao<string>.Falha(false, "Registro de usuário", "Nome do usuário já cadastrado no sistema!");
            }
            string erros;
            if(!usuario.Validacao(out erros))
            {
                return RespostaPadrao<string>.Falha(false, "Registro de usuário", erros);
            }

            _usuarioRepositorio.Adicionar(usuario);
            return RespostaPadrao<string>.Sucesso(true, "Registro de usuário", "Usuário registrado com sucesso!");

        }
    }
}
