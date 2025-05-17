using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using Dominio.Entidades;
using Moq;
using WinFormsApp2;
using Xunit;
using System.Windows.Forms;
using System.Reflection;
using System;
using Microsoft.Extensions.DependencyInjection;
using Aplicação.RespostaPadrao;

namespace WinFormsApp2.Test
{
    public class FormsLoginTest
    {
        private readonly Mock<IRealizarLoginUseCase> _mockLoginUseCase;
        private readonly Mock<IServiceProvider> _mockServiceProvider;
        private readonly Mock<UsuarioContexto> _mockUsuarioContexto;
        private readonly FormLogin _formLogin;

        public FormsLoginTest()
        {
            _mockLoginUseCase = new Mock<IRealizarLoginUseCase>();
            _mockServiceProvider = new Mock<IServiceProvider>();
            _mockUsuarioContexto = new Mock<UsuarioContexto>();

            _formLogin = new FormLogin(
                _mockLoginUseCase.Object,
                _mockServiceProvider.Object,
                _mockUsuarioContexto.Object
            );
        }

        private void SetTextBoxValue(string name, string value)
        {
            var control = _formLogin.Controls.Find(name, true).FirstOrDefault();
            if (control is TextBox textBox)
            {
                textBox.Text = value;
            }
        }

        [Fact]
        public void TestarLoginComCamposVazios_DeveNaoChamarExecutar()
        {
            // Arrange
            SetTextBoxValue("textBoxUsuario", "");
            SetTextBoxValue("textBoxSenha", "");

            // Act
            _formLogin.btnEntrar_Click(_formLogin.btnEntrar, EventArgs.Empty);

            // Assert
            _mockLoginUseCase.Verify(x => x.Executar(It.IsAny<LoginDTO>()), Times.Never());
        }

        [Fact]
        public void TestarLoginValido_DeveChamarExecutarAtualizarContextoEMostrarFormPrincipal()
        {
            // Arrange
            var usuarioEsperado = new Usuario(
                id: Guid.NewGuid(),
                dataCriacao: DateTime.Now,
                nome: "usuarioValido",
                senha: "senhaValida",
                email: "email@valido.com"
            );

            var respostaEsperada = new RespostaPadrao<Usuario>(
                procede: true,
                mensagem: "Login realizado com sucesso",
                dados: usuarioEsperado
            );

            // Use a real instance instead of a mock for FormInicio2 to avoid proxy issues
            var formInicio2 = new FormInicio2(null, _mockServiceProvider.Object);

            _mockLoginUseCase
                .Setup(uc => uc.Executar(It.IsAny<LoginDTO>()))
                .Returns(respostaEsperada);

            _mockServiceProvider
                .Setup(sp => sp.GetService(typeof(FormInicio2)))
                .Returns(formInicio2);

            SetTextBoxValue("textBoxUsuario", "viniciussoave");
            SetTextBoxValue("textBoxSenha", "!to5ebrc");

            // Act
            _formLogin.btnEntrar_Click(_formLogin.btnEntrar, EventArgs.Empty);

            // Assert
            _mockLoginUseCase.Verify(
                uc => uc.Executar(It.Is<LoginDTO>(
                    dto => dto.Usuario == "viniciussoave" && dto.Senha == "!to5ebrc"
                )),
                Times.Once()
            );

            _mockServiceProvider.Verify(
                sp => sp.GetService(typeof(FormInicio2)),
                Times.Once()
            );

            Assert.False(_formLogin.Visible);
        }

    }
}