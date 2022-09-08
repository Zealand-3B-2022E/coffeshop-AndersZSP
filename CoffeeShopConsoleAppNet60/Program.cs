using CoffeeShopConsoleAppNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        Cortado cortado = new Cortado();
        Latte latte = new Latte();
        BlackCoffee blackCoffee = new BlackCoffee();

        List<Coffee> coffeeList = new List<Coffee>();
        coffeeList.Add(blackCoffee);
        coffeeList.Add(cortado);
        coffeeList.Add(latte);

        foreach (Coffee coffee in coffeeList)
        {
            Console.WriteLine(coffee.Strength());
            Console.WriteLine(coffee.Price());
        }
    }
}