using Decorator.Decorators;
using Decorator.Entities;
using Decorator.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Crie um carro básico
        ICarro basicCar = new CarroBasico();
        Console.WriteLine($"Descrição: {basicCar.Description()}");
        Console.WriteLine($"Custo: {basicCar.Cost()}");

        // Adicione bancos de couro ao carro
        ICarro carWithLeatherSeats = new AssentoCouroDecorator(basicCar);
        Console.WriteLine($"Descrição: {carWithLeatherSeats.Description()}");
        Console.WriteLine($"Custo: {carWithLeatherSeats.Cost()}");

        // Adicione teto solar ao carro com bancos de couro
        ICarro carWithLeatherSeatsAndSunroof = new TetoSolarDecorator(carWithLeatherSeats);
        Console.WriteLine($"Descrição: {carWithLeatherSeatsAndSunroof.Description()}");
        Console.WriteLine($"Custo: {carWithLeatherSeatsAndSunroof.Cost()}");

        Console.ReadKey();
    }
}
