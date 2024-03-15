using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int size;
        int[] arr;
        int[] temp;

        size = int.Parse(Console.ReadLine());
        arr = new int[size];
        temp = new int[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        MergeSort(arr, temp, 0, size - 1);
        PrintArray(arr);
    }

    static void MergeSort(int[] arr, int[] temp, int left, int right)
    {
        int mid = (left + right) / 2;
        if (left < right)
        {
            MergeSort(arr, temp, left, mid);
            MergeSort(arr, temp, mid + 1, right);
            Merge(arr, temp, left, mid, right);
        }
    }

    static void Merge(int[] arr, int[] temp, int start, int mid, int end)
    {
        int low = start;
        int high = mid + 1;
        int index = start;

        while (low <= mid && high <= end)
        {
            temp[index++] = arr[low] < arr[high] ? arr[low++] : arr[high++];
        }

        while (low <= mid)
        {
            temp[index++] = arr[low++];
        }

        while (high <= end)
        {
            temp[index++] = arr[high++];
        }

        for (int i = start; i <= end; ++i)
        {
            arr[i] = temp[i];
        }
    }

    static void PrintArray(int[] arr)
    {
        StringBuilder sb = new StringBuilder();
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            sb.Append($"{arr[i]}\n");
        }
        Console.WriteLine(sb.ToString());
    }
}