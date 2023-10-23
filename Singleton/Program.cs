using DesignPatttern.Singleton;

class Program
{
    static void Main(string[] args)
    {
        int numberOfThreads = 5;
        Task[] tasks = new Task[numberOfThreads];

        for (int i = 0; i < numberOfThreads; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                var singleton = Singleton.Instance;
                Console.WriteLine($"Thread {Task.CurrentId} - Singleton Instance HashCode: {singleton.GetHashCode()}");
            });
        }

        Task.WaitAll(tasks);

        Console.ReadKey();
    }
}