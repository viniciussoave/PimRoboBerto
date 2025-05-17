// Na pasta de testes (LoginApp.Tests)
using Xunit;
using Moq;
using WinFormsApp2;
using Aplicação.DTOs;
using Aplicação.Interfaces_Caso_De_Uso;
using Dominio.Entidades;
using Microsoft.Extensions.DependencyInjection;

public class FormLoginTests
{
    [Fact]
    public void LoginComCamposVazios_NaoDeveChamarCasoDeUso()
    {
        // Arrange
        var mockLoginUseCase = new Mock<IRealizarLoginUseCase>();
        var mockServiceProvider = new Mock<IServiceProvider>();
        var mockUsuarioContexto = new Mock<UsuarioContexto>();

        var form = new FormLogin(
            mockLoginUseCase.Object,
            mockServiceProvider.Object,
            mockUsuarioContexto.Object
        );

        // Manually clear fields (ajuste os modificadores de acesso para internal se necessário)
        form.textBoxUsuario.Text = string.Empty;
        form.textBoxSenha.Text = string.Empty;

        // Act
        form.btnEntrar_Click(null, EventArgs.Empty);

        // Assert
        mockLoginUseCase.Verify(
            x => x.Executar(It.IsAny<LoginDTO>()),
            Times.Never(),
            "Não deve chamar o caso de uso com campos vazios"
        );
    }

    [Fact]
    public void LoginValido_DeveNavegarParaProximaTelaEAtualizarContexto()
    {
        // Arrange
        var mockLoginUseCase = new Mock<IRealizarLoginUseCase>();
        var mockServiceProvider = new Mock<IServiceProvider>();
        var mockUsuarioContexto = new Mock<UsuarioContexto>();
        var mockFormHistorico = new Mock<FormInicio2>();

        // Configurar mocks
        var usuarioEsperado = new Usuario();
        mockLoginUseCase.Setup(x => x.Executar(It.IsAny<LoginDTO>()))
            .Returns(new Resposta<Usuario>(usuarioEsperado, true, "Sucesso"));

        mockServiceProvider.Setup(x => x.GetRequiredService<FormInicio2>())
            .Returns(mockFormHistorico.Object);

        var form = new FormLogin(
            mockLoginUseCase.Object,
            mockServiceProvider.Object,
            mockUsuarioContexto.Object
        );

        form.textBoxUsuario.Text = "usuario";
        form.textBoxSenha.Text = "senha";

        // Act
        form.btnEntrar_Click(null, EventArgs.Empty);

        // Assert
        mockLoginUseCase.Verify(
            x => x.Executar(It.Is<LoginDTO>(dto =>
                dto.Usuario == "usuario" && dto.Senha == "senha"),
            Times.Once(),
            "Deve chamar o caso de uso com credenciais corretas"
        );

        mockUsuarioContexto.Verify(
            x => x.DefinirUsuario(usuarioEsperado),
            Times.Once(),
            "Deve atualizar o contexto do usuário"
        );

        mockServiceProvider.Verify(
            x => x.GetRequiredService<FormInicio2>(),
            Times.Once(),
            "Deve solicitar a próxima tela"
        );
    }
}