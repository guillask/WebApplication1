using Application.Lancamento;
using Domain;
using Infrastructure.Lancamento;
using Moq;

namespace Tests.Services
{
    public class LancamentoServiceTests
    {
        private readonly LancamentoService _service;
        private readonly Mock<ILancamentoRepository> _repositoryMock;

        public LancamentoServiceTests()
        {
            _repositoryMock = new Mock<ILancamentoRepository>();
            _service = new LancamentoService(_repositoryMock.Object);
        }

        [Fact]
        public async Task Obter_DeveRetornarListaDeLancamentos()
        {
            // Arrange
            var lancamentos = new List<Lancamento>
            {
                new Lancamento { Id = 1, Valor = 10 }
            };

            _repositoryMock.Setup(repo => repo.Obter()).ReturnsAsync(lancamentos);

            // Act
            var result = await _service.Obter();

            // Assert
            Assert.Single(result);
            Assert.Equal(10, result[0].Valor);
        }

        [Fact]
        public async Task Adicionar_DeveChamarMetodoDoRepositorio()
        {
            // Arrange
            var novoLancamento = new Lancamento { Id = 2, Valor = 20 };

            // Act
            await _service.Adicionar(novoLancamento);

            // Assert
            _repositoryMock.Verify(repo => repo.Adicionar(novoLancamento), Times.Once);
        }
    }
}
