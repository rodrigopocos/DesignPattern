namespace Flyweight
{
    public class Font
    {
        private readonly string name;
        private readonly int size;

        public Font(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public void Render(string text)
        {
            Console.WriteLine($"Renderizando texto '{text}' na fonte '{name}' de tamanho {size}.");
        }
    }

}
