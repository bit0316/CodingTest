public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int sizeA;
    static int sizeB;
    static int[] arrA;
    static int[] arrB;

    static void Main(string[] args)
    {
        int[] result;

        sizeA = int.Parse(SR.ReadLine());
        arrA = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        sizeB = int.Parse(SR.ReadLine());
        arrB = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] GetResult()
    {
        List<int> result = new List<int>();
        int num = arrA.Max() > arrB.Max() ? arrA.Max() : arrB.Max();
        int indexA = 0;
        int indexB = 0;
        int tempA, tempB;

        while (num > 0)
        {
            tempA = GetArrayIndex(arrA, sizeA, indexA, num);
            tempB = GetArrayIndex(arrB, sizeB, indexB, num);

            if (tempA != -1 && tempB != -1)
            {
                result.Add(num);
                indexA = tempA + 1;
                indexB = tempB + 1;
                continue;
            }
            num--;
        }

        return result.ToArray();
    }

    static int GetArrayIndex(int[] arr, int size, int start, int num)
    {
        for (int i = start; i < size; ++i)
        {
            if (arr[i] == num)
            {
                return i;
            }
        }
        return -1;
    }

    static void PrintResult(int[] result)
    {
        SW.WriteLine(result.Length);
        foreach (int num in result)
        {
            SW.Write($"{num} ");
        }
    }
}