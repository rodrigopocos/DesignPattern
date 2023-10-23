namespace Prototype
{
    public class Pessoa : ICloneable
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Implementação do método Clone da interface ICloneable
        public object Clone()
        {
            return new Pessoa(Nome, Idade);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}
