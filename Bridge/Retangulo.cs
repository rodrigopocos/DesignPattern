namespace Bridge
{
    public class Retangulo : Forma
    {
        private int width;
        private int height;
        private int x;
        private int y;

        public Retangulo(int width, int height, int x, int y, IDesenhoApi drawApi) : base(drawApi)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            drawApi.DrawRectangle(width, height, x, y);
        }
    }
}
