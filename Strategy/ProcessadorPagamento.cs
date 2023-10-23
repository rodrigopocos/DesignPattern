using Strategy.Strategies.Interfaces;

namespace Strategy
{
    public class ProcessadorPagamento
    {
        private readonly IDescontoStrategy _descontoStrategy;

        public ProcessadorPagamento(IDescontoStrategy descontoStrategy) => _descontoStrategy = descontoStrategy;

        public double ProcessarPagamento(double valorOriginal) => _descontoStrategy.AplicarDesconto(valorOriginal);
    }
}
