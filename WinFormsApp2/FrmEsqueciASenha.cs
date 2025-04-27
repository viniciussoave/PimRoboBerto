using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
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

        private readonly IRecuperarSenhaUseCase _recuperarSenhaUseCase;

        public FrmEsqueciASenha(IRecuperarSenhaUseCase recuperarSenhaUseCase)
        {
            InitializeComponent();
            _recuperarSenhaUseCase = recuperarSenhaUseCase;
        }


        private void BtnEnviarConfirmacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Campo do email em branco!");
            }

            var resposta = _recuperarSenhaUseCase.Executar(txtEmail.Text);

           // MessageBoxIcon icone = resposta.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
           // MessageBox.Show(resposta.Dados, resposta.Mensagem, MessageBoxButtons.OK, icone);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
