namespace Flyweight
{
    public class FontFactory
    {
        private readonly Dictionary<string, Font> fonts = new Dictionary<string, Font>();

        public Font GetFont(string name, int size)
        {
            string key = $"{name}-{size}";

            if (!fonts.ContainsKey(key))
            {
                fonts[key] = new Font(name, size);
            }

            return fonts[key];
        }
    }

}
