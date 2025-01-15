// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static int Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        int totalRolls = int.Parse(Console.ReadLine());

        return totalRolls;
    }
}