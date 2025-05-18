using Aplicação.Casos_de_Uso;
using Aplicação.DTOs;
using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using Moq;

namespace Aplicação.Tests.Casos_de_Uso
{
    public class RegistrarUsuarioUseCaseTests
    {
        private readonly Mock<IUsuarioRepositorio> _usuarioRepositorioMock;
        private readonly RegistrarUsuarioUseCase _useCase;

        public RegistrarUsuarioUseCaseTests()
        {
            _usuarioRepositorioMock = new Mock<IUsuarioRepositorio>();
            _useCase = new RegistrarUsuarioUseCase(_usuarioRepositorioMock.Object);
        }

        [Fact]
        public void Deve_retornar_falha_se_email_ja_existir()
        {
            // Arrange
            var dto = new UsuarioDTO
            {
                Nome = "joao",
                Senha = "senha123",
                Email = "joao@email.com"
            };

            _usuarioRepositorioMock.Setup(repo => repo.ExisteEmail(dto.Email)).Returns(true);

            // Act
            var resposta = _useCase.Executar(dto);

            // Assert
            Assert.False(resposta.Procede);
            Assert.Equal("Email já cadastrado no sistema!", resposta.Dados);
        }

        [Fact]
        public void Deve_retornar_falha_se_nome_usuario_ja_existir()
        {
            // Arrange
            var dto = new UsuarioDTO
            {
                Nome = "joao",
                Senha = "senha123",
                Email = "novo@email.com"
            };

            _usuarioRepositorioMock.Setup(repo => repo.ExisteEmail(dto.Email)).Returns(false);
            _usuarioRepositorioMock.Setup(repo => repo.NomeUsuarioExiste(dto.Nome)).Returns(true);

            // Act
            var resposta = _useCase.Executar(dto);

            // Assert
            Assert.False(resposta.Procede);
            Assert.Equal("Nome do usuário já cadastrado no sistema!", resposta.Dados);
        }

        [Fact]
        public void Deve_retornar_falha_se_validacao_do_usuario_falhar()
        {
            // Arrange
            var dto = new UsuarioDTO
            {
                Nome = "", // inválido
                Senha = "senha123",
                Email = "valido@email.com"
            };

            _usuarioRepositorioMock.Setup(repo => repo.ExisteEmail(dto.Email)).Returns(false);
            _usuarioRepositorioMock.Setup(repo => repo.NomeUsuarioExiste(dto.Nome)).Returns(false);

            // Act
            var resposta = _useCase.Executar(dto);

            // Assert
            Assert.False(resposta.Procede);
            Assert.Contains("Nome", resposta.Dados); // espera-se que o erro mencione o nome
        }

        
        
    }
}
