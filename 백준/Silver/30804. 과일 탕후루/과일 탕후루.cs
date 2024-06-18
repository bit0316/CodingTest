public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;
    static int[] countArr;

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        countArr = new int[10];

        SW.WriteLine(TwoPointer(0, 0));

        SR.Close();
        SW.Close();
    }
    
    static int TwoPointer(int left, int right)
    {
        int result = 0;
        int count = 0;
        int kind = 0;

        while (right < size)
        {
            if (countArr[arr[right]] == 0)
            {
                kind++;
            }

            count++;
            countArr[arr[right]]++;

            while (kind > 2)
            {
                if (--countArr[arr[left]] == 0)
                {
                    kind--;
                }
                count--;
                left++;
            }

            result = Math.Max(result, count);
            right++;
        }

        return result;
    }
}