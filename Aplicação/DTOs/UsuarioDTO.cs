using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.DTOs
{
    public class UsuarioDTO
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public UsuarioDTO()
        {
        }

        public UsuarioDTO(Guid id, string nome, string senha, string email)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Email = email;
        }

    }
}

