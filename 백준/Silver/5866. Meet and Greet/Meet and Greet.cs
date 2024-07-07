public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_MOVE = 1000001;

    static int sizeA;
    static int sizeB;
    static int[] moveA;
    static int[] moveB;
    static string[] input;

    static void Main(string[] args)
    {
        int result;

        input = SR.ReadLine().Split();
        sizeA = int.Parse(input[0]);
        sizeB = int.Parse(input[1]);

        moveA = SetMovement(sizeA);
        moveB = SetMovement(sizeB);
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetMovement(int size)
    {
        int[] arr = new int[MAX_MOVE];
        int index = 0;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            for (int j = int.Parse(input[0]); j > 0; --j)
            {
                arr[index++] = input[1] == "L" ? -1 : 1;
            }
        }

        return arr;
    }

    static int GetResult()
    {
        int distanceA = moveA.Sum(x => Math.Abs(x));
        int distanceB = moveB.Sum(x => Math.Abs(x));
        int max = distanceA > distanceB ? distanceA : distanceB;
        int posA = 0;
        int posB = 0;
        int indexA = 0;
        int indexB = 0;
        int count = 0;

        for (int i = 0; i < max; ++i)
        {
            if (indexA < distanceA)
            {
                posA += moveA[indexA];
            }
            if (indexB < distanceB)
            {
                posB += moveB[indexB];
            }
            if (moveA[indexA++] != moveB[indexB++] && posA == posB)
            {
                count++;
            }
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}