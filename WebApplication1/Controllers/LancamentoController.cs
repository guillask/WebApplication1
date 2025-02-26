using Application.Lancamento;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LancamentoController(ILancamentoService lancamentoService) : ControllerBase
    {
        private readonly ILancamentoService _lancamentoService = lancamentoService;

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] Lancamento lancamento)
        {
            await _lancamentoService.Adicionar(lancamento);
            return CreatedAtAction(nameof(Adicionar), lancamento);
        }

        [HttpGet]
        public async Task<IActionResult> Obter()
        {
            var lancamentos = await _lancamentoService.Obter();
            return Ok(lancamentos);
        }
    }
}
