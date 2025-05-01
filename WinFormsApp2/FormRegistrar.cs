using Aplicação;
using Aplicação.Casos_de_Uso;
using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormRegistrar : Form
    {

        private FormInicio _formInicio;
        private bool _estaTrocandoTela = false;
        private readonly IRegistrarUsuarioUseCase _registrarUsuarioUseCase;
        private readonly IServiceProvider _serviceProvider;

        public FormRegistrar(IRegistrarUsuarioUseCase registrarUsuarioUseCase, IServiceProvider serviceProvider)
        {
            _registrarUsuarioUseCase = registrarUsuarioUseCase;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            textBoxUsuario.KeyPress += textBox_KeyPress;
            textBoxSenha.KeyPress += textBox_KeyPress;
            textBoxConfirmarSenha.KeyPress += textBox_KeyPress;
            textBoxEmail.KeyPress += textBox_KeyPress;
        }

       //public FormRegistrar(IRegistrarUsuarioUseCase registrarUsuarioUseCase, IRealizarLoginUseCase realizarLoginUseCase)
       //{
       //    _realizarLoginUseCase = realizarLoginUseCase;
       //    _registrarUsuarioUseCase = registrarUsuarioUseCase;
       //}

      

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Impede que o usuário pressione Enter para criar uma nova linha
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Ignora a tecla Enter e o espaço
            }
        }

//      public static bool IsValidEmail(string email)
//      {
//          if (string.IsNullOrWhiteSpace(email))
//              return false;
//
//          try
//          {
//              string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//              Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
//              return regex.IsMatch(email);
//          }
//          catch (RegexMatchTimeoutException)
//          {
//              return false;
//          }
//      }
//
//      static bool ContemDigitoEspecialOuNumero(string senha)
//      {
//          // Expressão regular para verificar dígitos especiais ou números
//          string padrao = @"[\d\W]";
//          return Regex.IsMatch(senha, padrao);
//      }
        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _estaTrocandoTela = true;
            this.Close();
            _formInicio = _serviceProvider.GetRequiredService<FormInicio>();
            _formInicio.StartPosition = FormStartPosition.Manual;
            _formInicio.Location = this.Location;
            _formInicio.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxSenha.Text) || string.IsNullOrEmpty(textBoxUsuario.Text) || string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Preencha todos os dados obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!textBoxSenha.Text.Equals(textBoxConfirmarSenha.Text))
            {
                MessageBox.Show("Senhas diferentes! Tente Novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            var usuarioDto = new UsuarioDTO
            {
                Email = textBoxEmail.Text,
                Nome = textBoxUsuario.Text,
                Senha = textBoxSenha.Text,
            };

            var resposta = _registrarUsuarioUseCase.Executar(usuarioDto);

            MessageBoxIcon icone = resposta.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(resposta.Dados, resposta.Mensagem, MessageBoxButtons.OK, icone);

            if (resposta.Procede)
            {
                LimparCampos();
            }
        }
        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
        }
        private void LimparCampos()
        {
            textBoxEmail.Clear();
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
            textBoxConfirmarSenha.Clear();
        }
        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}