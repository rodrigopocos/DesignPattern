using Strategy.Strategies.Interfaces;

namespace Strategy.Strategy
{
    public class DescontoFixoStrategy : IDescontoStrategy
    {
        private readonly double valorDesconto;

        public DescontoFixoStrategy(double valorDesconto) => this.valorDesconto = valorDesconto;

        public double AplicarDesconto(double valorOriginal) => valorOriginal - valorDesconto;
    }
}
