using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using Aplicação.RespostaPadrao;
using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Casos_de_Uso
{
    public class RealizarLoginUseCase : IRealizarLoginUseCase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public RealizarLoginUseCase(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public RespostaPadrao<Usuario> Executar(LoginDTO loginDto)
        {
            bool usuarioExiste = _usuarioRepositorio.NomeUsuarioExiste(loginDto.Usuario);

            if (!usuarioExiste)
            {
                return RespostaPadrao<Usuario>.Falha(false, "Usuário incorreto!", null);  // Alterado aqui para Usuario
            }

            var usuario = _usuarioRepositorio.RecuperarPorNome(loginDto.Usuario);

            if (!usuario.VerificarSenha(loginDto.Senha))
            {
                return RespostaPadrao<Usuario>.Falha(false, "Senha incorreta!",null);  // Alterado aqui para Usuario
            }

            return RespostaPadrao<Usuario>.Sucesso(true, "Login", usuario);  // Está correto, pois o retorno é Usuario
        }


    }
}
