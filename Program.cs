// See https://aka.ms/new-console-template for more information

using Mission1SebastianMcFarland;

public class Program
{
    public static void Main(string[] args)
    {
        int[] results = new int[11]; // Array to count combinations of 2 to 12

        Console.WriteLine("Welcome to the dice throwing simulator!");
        
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        int totalRolls = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < totalRolls; i++)
        {
            int diceResult = RollDice.RollDiceOnce();
            RollDice.Counter(results, diceResult);
        }

        // Print results
        for (int i = 0; i < results.Length; i++)
        {
            int percentage = (int)Math.Ceiling((results[i] / (float)totalRolls) * 100);
            
            Console.Write($"{i + 2}: ");
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }
}
