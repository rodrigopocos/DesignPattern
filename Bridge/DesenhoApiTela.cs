namespace Bridge
{
    public class DesenhoApiTela : IDesenhoApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Desenhando um círculo na tela com raio {radius}, x = {x}, y = {y}");
        }

        public void DrawRectangle(int width, int height, int x, int y)
        {
            Console.WriteLine($"Desenhando um retângulo na tela com largura {width}, altura {height}, x = {x}, y = {y}");
        }
    }
}
