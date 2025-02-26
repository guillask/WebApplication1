using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Lancamento
{
    public class LancamentoRepository(AppDbContext context) : ILancamentoRepository
    {
        private readonly AppDbContext _context = context;

        public async Task Adicionar(Domain.Lancamento entity)
        {
            await _context.Lancamentos.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Domain.Lancamento>> Obter()
        {
            return await _context.Lancamentos
                        .Include(l => l.TipoLancamento)
                        .ToListAsync();
        }
    }
}
