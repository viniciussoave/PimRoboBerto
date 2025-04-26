using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface_Repositorios
{
    public interface IUsuarioRepositorio
    {

        public void Adicionar(Usuario usuario);
        public bool ExisteEmail(string email);
        public bool NomeUsuarioExiste(string nomeUsuario);
        public Usuario RecuperarPorNome(string nome);

    }
}
