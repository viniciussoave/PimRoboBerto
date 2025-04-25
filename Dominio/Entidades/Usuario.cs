using Dominio.Validacoes;
using Dominio.Validacoes.Interface_Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuario : ModeloAbstrato, IContrato
    {

        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }

        public Usuario(string nome, string senha, string email) : base()
        {
            Nome = nome;
            Senha = senha;
            Email = email;
        }
        public static Usuario CriarModelo(string nome, string senha, string email)
        {
            return new Usuario(nome, senha, email);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";
            var contratos = new ContratoValidacoes<Usuario>().NomeEstaOk(Nome, 3, "Nome inválido. Deve conter pelo menos 3 caracteres.", "Nome")
                .EmailEstaOk(Email, "Email Inválido, insira um email válido!", "Email");

            if (!contratos.EhValido())
            {
                erros = contratos.CapturadorErros();
                return false;
            }
            return true;
        }
    }
}

