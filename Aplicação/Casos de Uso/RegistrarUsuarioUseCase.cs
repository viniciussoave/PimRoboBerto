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
