namespace Composite
{
    public class Employee : IComponent
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void Display()
        {
            Console.WriteLine($"Funcionário: {name}");
        }
    }
}
