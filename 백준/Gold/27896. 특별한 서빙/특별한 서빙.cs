public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int result;
        int student;
        int limit;
        int[] arr;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        student = input[0];
        limit = input[1];
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult(student, limit, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int student, int limit, int[] arr)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int count = 0;
        int sum = 0;

        for (int i = 0; i < student; ++i)
        {
            sum += arr[i];
            pq.Enqueue(arr[i], -arr[i]);

            while (sum >= limit)
            {
                sum -= 2 * pq.Dequeue();
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