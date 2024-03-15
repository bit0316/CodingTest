public class Program
{
    static void Main(string[] args)
    {
        int size;
        int blackjack;
        int result;
        int[] cards;
        string[] input;

        input = Console.ReadLine().Split();
        size = int.Parse(input[0]);
        blackjack = int.Parse(input[1]);
        cards = new int[size];

        input = Console.ReadLine().Split();
        for (int i = 0; i < size; ++i)
        {
            cards[i] = int.Parse(input[i]);
        }

        result = GetBestPick(cards, blackjack);
        Console.WriteLine(result);
    }

    static int GetBestPick(int[] cards, int blackjack)
    {
        int size = cards.Length;
        int bestValue = 0;

        int result = 0;
        for (int i = 0; i < size - 2; ++i)
        {
            for (int j = i + 1; j < size - 1; ++j)
            {
                for (int k = j + 1; k < size; ++k)
                {
                    result = cards[i] + cards[j] + cards[k];
                    if (result <= blackjack && result > bestValue)
                    {
                        bestValue = result;
                    }
                }
            }
        }

        return bestValue;
    }
}