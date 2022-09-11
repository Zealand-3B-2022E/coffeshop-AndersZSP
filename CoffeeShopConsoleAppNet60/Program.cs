using CoffeeShopConsoleAppNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How high a discount?");
        string strDiscount = Console.ReadLine();
        int discount = Int32.Parse(strDiscount);
        Cortado cortado = new Cortado(discount);
        Latte latte = new Latte(discount);
        BlackCoffee blackCoffee = new BlackCoffee(discount);

        List<Coffee> coffeeList = new List<Coffee>();
        coffeeList.Add(blackCoffee);
        coffeeList.Add(cortado);
        coffeeList.Add(latte);

        foreach (Coffee coffee in coffeeList)
        {
            Console.WriteLine(coffee.Strength());
            Console.WriteLine(coffee.Price());
        }

        Console.WriteLine("ASSIGNMENT 8");
        //Assignment 8 milk only. CAN'T GET IT TO WORK



        
    }
}