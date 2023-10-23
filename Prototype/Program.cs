using Newtonsoft.Json;
using Prototype;

class Program
{
    static void Main(string[] args)
    {
        // Crie um objeto Person como protótipo
        var prototypePessoa = new Pessoa("Alice", 30);

        // Faça cópias do protótipo usando o método Clone
        var pessoa1 = (Pessoa)prototypePessoa.Clone();
        pessoa1.Nome = "José";

        var person2 = (Pessoa)prototypePessoa.Clone();
        person2.Nome = "João";

        // Exiba os objetos criados
        Console.WriteLine($"Person 1: {pessoa1}");
        Console.WriteLine($"Person 2: {person2}");
    }
}
