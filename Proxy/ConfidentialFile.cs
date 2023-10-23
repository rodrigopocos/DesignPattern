namespace Proxy
{
    public class ConfidentialFile : ISystemResource
    {
        private string filename;

        public ConfidentialFile(string filename)
        {
            this.filename = filename;
        }

        public void AccessResource(string username)
        {
            Console.WriteLine($"Usuário '{username}' acessou o arquivo confidencial: {filename}");
        }
    }
}
