public class Program
{
    static void Main(string[] args)
    {
        int size;
        int count = 0;
        int[] check = new int[26];
        string input;

        size = int.Parse(Console.ReadLine());

        bool isGroup;
        int index;
        for (int i = 0; i < size; ++i)
        {
            isGroup = true;
            check = new int[26];
            input = Console.ReadLine().ToUpper();

            for (int j = 0; j < input.Length; ++j)
            {
                index = int.Parse((input[j] - 'A').ToString());
                if (input.Length == 1)
                {
                    break;
                }
                else if (check[index] > 0)
                {
                    isGroup = false;
                    break;
                }
                else if (j < input.Length - 1 && input[j] != input[j + 1])
                {
                    check[index]++;
                }
            }

            if (isGroup)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}