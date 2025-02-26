namespace Domain
{
    public class Lancamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public TipoLancamento? TipoLancamento { get; set; }
    }
}
