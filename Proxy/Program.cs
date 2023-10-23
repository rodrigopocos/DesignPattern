using Proxy;

class Program
{
    static void Main(string[] args)
    {
        // Crie o proxy para o arquivo confidencial
        ResourceProxy proxy = new ResourceProxy("arquivo_confidencial.txt");

        // Tente acessar o recurso sem autenticação
        proxy.AccessResource("outro_usuario");

        // Autentique-se com um usuário válido
        proxy.Authenticate("usuario", "senha");

        // Tente acessar o recurso novamente
        proxy.AccessResource("usuario");

        Console.ReadKey();
    }
}
