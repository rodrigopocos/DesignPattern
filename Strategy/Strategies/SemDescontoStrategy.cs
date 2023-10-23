using Strategy.Strategies.Interfaces;

namespace Strategy.Strategy
{
    public class SemDescontoStrategy : IDescontoStrategy
    {
        public double AplicarDesconto(double valorOriginal) => valorOriginal;
    }
}
