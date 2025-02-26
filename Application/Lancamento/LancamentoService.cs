using Infrastructure.Lancamento;

namespace Application.Lancamento
{
    public class LancamentoService(ILancamentoRepository repository) : ILancamentoService
    {
        private readonly ILancamentoRepository _repository = repository;

        public async Task Adicionar(Domain.Lancamento entity)
        {
            await _repository.Adicionar(entity);
        }

        public async Task<List<Domain.Lancamento>> Obter()
        {
            return await _repository.Obter();
        }
    }
}
