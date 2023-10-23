namespace Proxy
{
    public class ResourceProxy : ISystemResource
    {
        private ISystemResource resource;
        private string username;
        private string password;

        public ResourceProxy(string filename)
        {
            resource = new ConfidentialFile(filename);
        }

        public void Authenticate(string username, string password)
        {
            // Simula a autenticação
            if (IsValidUser(username, password))
            {
                this.username = username;
                this.password = password;
                Console.WriteLine($"Usuário '{username}' autenticado com sucesso.");
            }
            else
            {
                Console.WriteLine("Falha na autenticação.");
            }
        }

        public void AccessResource(string username)
        {
            if (this.username == username)
            {
                resource.AccessResource(username);
            }
            else
            {
                Console.WriteLine("Acesso negado. Por favor, faça login.");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Simula a validação do usuário e senha
            return username == "usuario" && password == "senha";
        }
    }
}
