public class Program
{
    static void Main(string[] args)
    {
        int size = 26;
        int[] arr;
        string input;

        input = Console.ReadLine();
        arr = new int[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = -1;
            for (int j = 0; j < input.Length; ++j)
            {
                if (('a' + i) == input[j])
                {
                    arr[i] = j;
                    break;
                }
            }
            Console.Write($"{arr[i]} ");
        }
    }
}