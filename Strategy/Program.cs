using Strategy;
using Strategy.Strategy;

class Program
{
    static void Main(string[] args)
    {
        // Cria um processador de pagamento sem desconto
        ProcessadorPagamento processadorSemDesconto = new ProcessadorPagamento(new SemDescontoStrategy());
        double valorSemDesconto = processadorSemDesconto.ProcessarPagamento(100.0);
        Console.WriteLine($"Total sem desconto: R$ {valorSemDesconto:F2}");

        // Cria um processador de pagamento com uma estratégia de desconto fixo de R$ 10
        const double descontoFixo = 10.0;
        ProcessadorPagamento processadorDescontoFixo = new ProcessadorPagamento(new DescontoFixoStrategy(descontoFixo));
        double valorComDescontoFixo = processadorDescontoFixo.ProcessarPagamento(100.0);
        Console.WriteLine($"Total com desconto fixo (R$ {descontoFixo:F2}): R$ {valorComDescontoFixo:F2}");

        // Cria um processador de pagamento com uma estratégia de desconto percentual de 20%
        const double descontoPercentual = 20.0;
        ProcessadorPagamento processadorDescontoPercentual = new ProcessadorPagamento(new DescontoPercentualStrategy(20.0));
        double valorComDescontoPercentual = processadorDescontoPercentual.ProcessarPagamento(100.0);
        Console.WriteLine($"Total com desconto percentual ({descontoPercentual:F2}%): R$ {valorComDescontoPercentual:F2}");

        Console.ReadKey();
    }
}
