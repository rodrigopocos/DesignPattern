namespace Bridge
{
    public class DesenhoApiImpressora : IDesenhoApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Imprimindo um círculo com raio {radius}, x = {x}, y = {y}");
        }

        public void DrawRectangle(int width, int height, int x, int y)
        {
            Console.WriteLine($"Imprimindo um retângulo com largura {width}, altura {height}, x = {x}, y = {y}");
        }
    }
}
