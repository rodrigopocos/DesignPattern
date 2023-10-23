using Composite;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Alice");
        Employee employee2 = new Employee("Bob");
        Employee employee3 = new Employee("Charlie");

        Department department1 = new Department("Departamento de Vendas");
        department1.AddComponent(employee1);
        department1.AddComponent(employee2);

        Department department2 = new Department("Departamento de Engenharia");
        department2.AddComponent(employee3);

        Department organization = new Department("Empresa");
        organization.AddComponent(department1);
        organization.AddComponent(department2);

        organization.Display();

        Console.ReadKey();
    }
}
