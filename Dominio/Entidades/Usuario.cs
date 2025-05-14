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

        private Usuario(string nome, string senha, string email) : base()
        {
            Nome = nome;
            Senha = senha;
            Email = email;
        }

        public Usuario(Guid id, DateTime dataCriacao, string nome, string senha, string email) : base(id,dataCriacao)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
        }
        public static Usuario CriarModelo(string nome, string senha, string email)
        {
            return new Usuario(nome, senha, email);
        }
        public static Usuario CriarModeloDoBanco(Guid id, DateTime dataCriacao, string nome, string senha, string email)
        {
            return new Usuario(id, dataCriacao, nome, senha, email);
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

        public void AlterarSenha(string novaSenha)
        {
        
            Senha = novaSenha;
    
        }
        public bool VerificarSenha(string senhaDigitada)
        {
            return Senha == senhaDigitada; 
        }
    }
}

