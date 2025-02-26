using Application.Lancamento;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LancamentoController(ILancamentoService lancamentoService, ILogger<LancamentoController> logger) : ControllerBase
    {
        private readonly ILancamentoService _lancamentoService = lancamentoService;
        private readonly ILogger<LancamentoController> _logger = logger;

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] Lancamento lancamento)
        {
            _logger.LogInformation("Recebida solicitação para adicionar um lançamento: {@Lancamento}", lancamento);

            await _lancamentoService.Adicionar(lancamento);

            _logger.LogInformation("Lançamento adicionado com sucesso: {@Lancamento}", lancamento);
            return CreatedAtAction(nameof(Adicionar), lancamento);
        }

        [HttpGet]
        public async Task<IActionResult> Obter()
        {
            _logger.LogInformation("Recebida solicitação para obter todos os lançamentos.");

            var lancamentos = await _lancamentoService.Obter();

            _logger.LogInformation("Retornando {Count} lançamentos.", lancamentos.Count);
            return Ok(lancamentos);
        }
    }
}
