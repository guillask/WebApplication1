namespace Application.Lancamento
{
    public interface ILancamentoService
    {
        Task Adicionar(Domain.Lancamento entity);
        Task<List<Domain.Lancamento>> Obter();
    }
}
