using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class FormLogin : Form
    {

        private readonly IRealizarLoginUseCase _realizarLoginUseCase;
        private Historico _frmHistorico;

        private bool _estaTrocandoTela = false;
        public FormLogin(IRealizarLoginUseCase realizarLoginUseCase)
        {
            InitializeComponent();
            //Isso serve para dentro dos campos, não ser apertado o espaço e o enter funcionar para entrar.
            textBoxUsuario.KeyPress += textBox_KeyPress;
            textBoxSenha.KeyPress += textBox_KeyPress;
            textBoxSenha.KeyPress += textBox_enterPress;
            _realizarLoginUseCase = realizarLoginUseCase;
        }


        //Essa variavel é usada para conseguirmos encerrar esse formulario quando apertar em voltar
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Impede que o usuário pressione Enter para criar uma nova linha
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Ignora a tecla Enter e o espaço
            }
        }

        private void textBox_enterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(1, EventArgs.Empty);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //    _estaTrocandoTela = true;
            //    this.Close();
            //    FormInicio Inicio = new FormInicio();
            //    Inicio.StartPosition = FormStartPosition.Manual;
            //    Inicio.Location = this.Location;
            //    Inicio.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSenha.Text) || string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                MessageBox.Show("Preencha todos os dados obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var loginDto = new LoginDTO
            {
                Usuario = textBoxUsuario.Text,
                Senha = textBoxSenha.Text
            };

            var resposta = _realizarLoginUseCase.Executar(loginDto);

            if (resposta.Procede)
            {
                _estaTrocandoTela = true;
                    this.Close();
                _frmHistorico = new Historico();
                _frmHistorico.StartPosition = FormStartPosition.Manual;
                _frmHistorico.Location = this.Location;
                _frmHistorico.Show();
            }

            MessageBoxIcon icone = resposta.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(resposta.Dados, resposta.Mensagem, MessageBoxButtons.OK, icone);
            return;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
