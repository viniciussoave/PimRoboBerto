using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Xunit;
using WinFormsApp2;
using Moq;
using System.Windows.Forms;
using System;

namespace EsqueciASenhaTeste
{
    //inicio teste 1
    public class UnitTest1
    {
        [Fact]
        public void Test1_BotaoEnviarConfirmacao_Email_vazio()
        {
            var mockRecuperarSenha = new Mock<IRecuperarSenhaUseCase>();
            var mockServiceProvider = new Mock<IServiceProvider>();
            var form = new FrmEsqueciASenha(
                mockServiceProvider.Object,
                mockRecuperarSenha.Object,
                null 
            );
            var txtEmail = new TextBox();
            form.Controls.Add(txtEmail);
            typeof(FrmEsqueciASenha)
                .GetField("txtEmail", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(form, txtEmail);

            txtEmail.Text = "";

            // Act
             form.BtnEnviarConfirmacao_Click(null, EventArgs.Empty);

            // Assert
            mockRecuperarSenha.Verify(
                x => x.Executar(It.IsAny<string>()),
                Times.Never() // Verifica se NÃO foi chamado
            );
        }
    } // fim teste 1
}