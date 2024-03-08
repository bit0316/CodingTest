public class Program
{
    static void Main(string[] args)
    {
        int size;
        int count;
        int[] arr;
        string[] input;

        input = Console.ReadLine().Split();
        size = int.Parse(input[0]);
        count = int.Parse(input[1]);
        arr = new int[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = i + 1;
        }

        int numA;
        int numB;
        for (int i = 0; i < count; ++i)
        {
            input = Console.ReadLine().Split();
            numA = int.Parse(input[0]) - 1;
            numB = int.Parse(input[1]) - 1;

            if (numA > numB)
            {
                (numA, numB) = (numB, numA);
            }
            while (numA < numB)
            {
                (arr[numA], arr[numB]) = (arr[numB], arr[numA]);
                numA++;
                numB--;
            }
        }

        for (int i = 0; i < size; ++i)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}