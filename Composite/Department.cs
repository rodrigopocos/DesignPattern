namespace Composite
{
    public class Department : IComponent
    {
        private string name;
        private List<IComponent> components = new List<IComponent>();

        public Department(string name)
        {
            this.name = name;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public string GetName()
        {
            return name;
        }

        public void Display()
        {
            Console.WriteLine($"Departamento: {name}");

            foreach (var component in components)
            {
                component.Display();
            }
        }
    }

}
