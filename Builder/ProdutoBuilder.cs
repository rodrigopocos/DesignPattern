namespace Builder
{
    public class ProdutoBuilder
    {
        private Produto produto = new Produto();

        public ProdutoBuilder SetNome(string nome)
        {
            produto.Nome = nome;
            return this;
        }

        public ProdutoBuilder SetPreco(decimal preco)
        {
            produto.Preco = preco;
            return this;
        }

        public ProdutoBuilder SetDescricao(string descricao)
        {
            produto.Descricao = descricao;
            return this;
        }

        public ProdutoBuilder SetTamanho(string tamanho)
        {
            produto.Tamanho = tamanho;
            return this;
        }

        public Produto Build()
        {
            return produto;
        }
    }
}
