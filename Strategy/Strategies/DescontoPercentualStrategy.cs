using Strategy.Strategies.Interfaces;

namespace Strategy.Strategy
{
    public class DescontoPercentualStrategy : IDescontoStrategy
    {
        private readonly double percentualDesconto;

        public DescontoPercentualStrategy(double percentualDesconto) => this.percentualDesconto = percentualDesconto;

        public double AplicarDesconto(double valorOriginal) => valorOriginal - valorOriginal * percentualDesconto / 100.0;
    }
}
