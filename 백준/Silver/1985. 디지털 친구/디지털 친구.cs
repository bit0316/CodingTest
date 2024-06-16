public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size = 3;
    static int[] numA;
    static int[] numB;
    static string[] input;

    static void Main(string[] args)
    {
        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            numA = input[0].Select(c => int.Parse(c.ToString())).ToArray();
            numB = input[1].Select(c => int.Parse(c.ToString())).ToArray();

            if (!numA.Except(numB).Any() && !numB.Except(numA).Any())
            {
                SW.WriteLine("friends");
            }
            else if (IsAlmostFriends(numA, numB) || IsAlmostFriends(numB, numA))
            {
                SW.WriteLine("almost friends");
            }
            else
            {
                SW.WriteLine("nothing");
            }
        }

        SR.Close();
        SW.Close();
    }

    static bool IsAlmostFriends(int[] numA, int[] numB)
    {
        for (int i = 0; i < numA.Length - 1; ++i)
        {
            if (numA[i] > 0 && numA[i + 1] < 9)
            {
                numA[i]--;
                numA[i + 1]++;
                if (!numA.Except(numB).Any() && !numB.Except(numA).Any() && numA[0] > 0)
                {
                    return true;
                }
                numA[i]++;
                numA[i + 1]--;
            }

            if (numA[i] < 9 && numA[i + 1] > 0)
            {
                numA[i]++;
                numA[i + 1]--;
                if (!numA.Except(numB).Any() && !numB.Except(numA).Any())
                {
                    return true;
                }
                numA[i]--;
                numA[i + 1]++;
            }
        }

        return false;
    }
}