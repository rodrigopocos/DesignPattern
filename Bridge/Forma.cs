namespace Bridge
{
    public abstract class Forma
    {
        protected IDesenhoApi drawApi;

        protected Forma(IDesenhoApi drawApi)
        {
            this.drawApi = drawApi;
        }

        public abstract void Draw();
    }
}
