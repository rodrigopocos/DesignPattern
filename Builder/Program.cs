using Builder;

class Program
{
    static void Main(string[] args)
    {
        Produto product1 = new ProdutoBuilder()
            .SetNome("Produto 1")
            .SetPreco(19.99m)
            .Build();

        Produto product2 = new ProdutoBuilder()
            .SetNome("Produto 2")
            .SetDescricao("Descrição do Produto 2")
            .SetTamanho("M")
            .Build();

        Console.WriteLine($"Produto 1: {product1.Nome}, {product1.Preco:C}");
        Console.WriteLine($"Produto 2: {product2.Nome}, {product2.Descricao}, {product2.Tamanho}");
    }
}
