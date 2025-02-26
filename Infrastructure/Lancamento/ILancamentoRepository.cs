namespace Infrastructure.Lancamento
{
    public interface ILancamentoRepository
    {
        Task Adicionar(Domain.Lancamento entity);
        Task<List<Domain.Lancamento>> Obter();
    }
}
