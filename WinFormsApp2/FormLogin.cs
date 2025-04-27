using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using Microsoft.Extensions.DependencyInjection;
namespace WinFormsApp2
{
    public partial class FormLogin : Form
    {
        private bool _estaTrocandoTela = false;
        private Historico _frmHistorico;
        private FormInicio _frmInicio;
        private readonly IRealizarLoginUseCase _realizarLoginUseCase;
        private readonly IServiceProvider _serviceProvider;

        public FormLogin(IRealizarLoginUseCase realizarLoginUseCase,IServiceProvider serviceProvider)
        {
            _realizarLoginUseCase = realizarLoginUseCase;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            //Isso serve para dentro dos campos, não ser apertado o espaço e o enter funcionar para entrar.
            textBoxUsuario.KeyPress += textBox_KeyPress;
            textBoxSenha.KeyPress += textBox_KeyPress;
            textBoxSenha.KeyPress += textBox_enterPress;
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
            _estaTrocandoTela = true;
            this.Close();
            _frmInicio = _serviceProvider.GetRequiredService<FormInicio>();
            _frmInicio.StartPosition = FormStartPosition.Manual;
            _frmInicio.Location = this.Location;
            _frmInicio.Show();
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
                _frmHistorico = _serviceProvider.GetRequiredService<Historico>();
                _frmHistorico.StartPosition = FormStartPosition.Manual;
                _frmHistorico.Location = this.Location;
                _frmHistorico.Show();
                return;

            }

            MessageBox.Show(resposta.Dados, resposta.Mensagem, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
