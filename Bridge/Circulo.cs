namespace Bridge
{
    public class Circulo : Forma
    {
        private int radius;
        private int x;
        private int y;

        public Circulo(int radius, int x, int y, IDesenhoApi drawApi) : base(drawApi)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            drawApi.DrawCircle(radius, x, y);
        }
    }
}
