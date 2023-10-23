namespace DesignPatttern.Singleton
{
    /// <summary>
    /// O padrão Singleton é um dos padrões de design mais comuns e úteis em engenharia de software.
    /// Ele é usado para garantir que uma classe tenha apenas uma instância e forneça um ponto de acesso global para essa instância.
    /// Isso é útil em situações em que você deseja compartilhar um único objeto em todo o seu aplicativo, como um gerenciador de configuração, um pool de conexões de banco de dados ou um registro de log.
    /// </summary>

    public class Singleton
    {
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
            // Construtor privado
        }

        public static Singleton Instance => lazyInstance.Value;
    }

}
