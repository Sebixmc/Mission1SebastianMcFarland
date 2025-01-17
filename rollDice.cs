namespace Mission1SebastianMcFarland;

public class RollDice
{
    private static Random random = new Random();
    public static int RollDiceOnce()
    {
        int min = 1;
        int max = 7;
        int dice1 = random.Next(min, max);
        int dice2 = random.Next(min, max);
        int diceResult = dice1 + dice2;
        return diceResult;
    }

    public static void Counter(int[] results, int diceResult)
    {
        results[diceResult - 2]++; // Increment the count for the corresponding result
    }
    
    
}