using Application.Lancamento;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebApplication1.Controllers;

namespace Tests.Controllers
{
    public class LancamentoControllerTests
    {
        private readonly Mock<ILancamentoService> _serviceMock;
        private readonly LancamentoController _controller;

        public LancamentoControllerTests()
        {
            _serviceMock = new Mock<ILancamentoService>();
            _controller = new LancamentoController(_serviceMock.Object);
        }

        [Fact]
        public async Task Obter_DeveRetornarOk_ComListaDeLancamentos()
        {
            // Arrange
            var lancamentos = new List<Lancamento>
            {
                new Lancamento { Id = 1, Valor = 10 },
                new Lancamento { Id = 2, Valor = 20 }
            };
            _serviceMock.Setup(s => s.Obter()).ReturnsAsync(lancamentos);

            // Act
            var result = await _controller.Obter();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<List<Lancamento>>(okResult.Value);
            Assert.Equal(2, model.Count);
        }

        [Fact]
        public async Task Adicionar_DeveRetornarCreatedAtAction()
        {
            // Arrange
            var novoLancamento = new Lancamento { Id = 3, Valor = 30 };

            // Act
            var result = await _controller.Adicionar(novoLancamento);

            // Assert
            var createdResult = Assert.IsType<CreatedAtActionResult>(result);
            var model = Assert.IsType<Lancamento>(createdResult.Value);
            Assert.Equal(30, model.Valor);
        }
    }
}
