using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Aplicação.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmEsqueciASenha : Form
    {
        private bool _estaTrocandoTela = false;
        private FormLogin _frmLogin;
        private readonly IServiceProvider _serviceProvider;
        private readonly IRecuperarSenhaUseCase _recuperarSenhaUseCase;
        private readonly IConfirmarCodigoVerificacaoUseCase _confirmarCodigoVerificacao;
        private EnviarEmailServico _email;
        private string _codigoVerificacaoGerado;

        public FrmEsqueciASenha(IServiceProvider serviceProvider, IRecuperarSenhaUseCase recuperarSenhaUseCase, IConfirmarCodigoVerificacaoUseCase confirmarCodigoVerificacao)
        {
            _recuperarSenhaUseCase = recuperarSenhaUseCase;
            _serviceProvider = serviceProvider;
            _confirmarCodigoVerificacao = confirmarCodigoVerificacao;
            InitializeComponent();
        }



        //      public FrmEsqueciASenha(IRecuperarSenhaUseCase recuperarSenhaUseCase)
        //      {
        //         
        //          _recuperarSenhaUseCase = recuperarSenhaUseCase;
        //      }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEsqueciASenha_Load(object sender, EventArgs e)
        {

        }

        private void lblInsiraCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }


        public async void BtnEnviarConfirmacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Digite seu email!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = await _recuperarSenhaUseCase.Executar(txtEmail.Text);

            if (resultado.Procede)
            {

                // O código já foi salvo como nova senha no banco pelo use case
                MessageBox.Show($"Sua nova senha foi enviada por email:\nUse-a para fazer login.",
                                "Senha Alterada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _estaTrocandoTela = true;
            this.Close();
            _frmLogin = _serviceProvider.GetRequiredService<FormLogin>();
            _frmLogin.StartPosition = FormStartPosition.Manual;
            _frmLogin.Location = this.Location;
            _frmLogin.Show();
        }

        private void PanelMsgs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
