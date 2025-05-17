using Xunit;
using Moq;
using WinFormsApp2;
using Aplicação.Casos_de_Uso;
using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp2.Tests
{
    public class FormChatTest

    {
       



       
      
        [Fact]
        public void QuandoClicarEmChatVoltar_DeveAbrirFormChat()
        {
            // Arrange
            var mockServiceProvider = new Mock<IServiceProvider>();
            var mockFormChat = new Mock<FormChat>();

            mockServiceProvider.Setup(x => x.GetRequiredService<FormChat>())
                               .Returns(mockFormChat.Object);

            var formInicio2 = new FormInicio2(new FormInicio(), mockServiceProvider.Object);

            // Act
            SimularCliqueNoBotao(formInicio2, "ChatVoltar");

            // Assert
            mockServiceProvider.Verify(
                x => x.GetRequiredService<FormChat>(),
                Times.Once
            );
        }

        private void SimularCliqueNoBotao(Form form, string nomeDoBotao)
        {
            var botao = form.Controls.Find(nomeDoBotao, true).FirstOrDefault();
            if (botao is Button btn)
            {
                btn.PerformClick();
            }
            else
            {
                throw new Exception($"Botão '{nomeDoBotao}' não encontrado.");
            }
        }
    }
}