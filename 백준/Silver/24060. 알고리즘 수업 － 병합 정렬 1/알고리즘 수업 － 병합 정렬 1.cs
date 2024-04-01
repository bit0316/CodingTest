public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int count = 0;
    static int order = 0;

    static void Main(string[] args)
    {
        int size;
        int[] arr;
        int[] temp;
        string[] input;

        input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        order = int.Parse(input[1]);
        temp = new int[size];
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        MergeSort(arr, temp, 0, size - 1, order);
        if (count < order)
        {
            SW.WriteLine(-1);
        }

        SR.Close();
        SW.Close();
    }

    static void MergeSort(int[] arr, int[] temp, int left, int right, int index)
    {
        int mid = (left + right) / 2;

        if (left < right)
        {
            MergeSort(arr, temp, left, mid, index);
            MergeSort(arr, temp, mid + 1, right, index);
            Merge(arr, temp, left, mid, right);
        }
    }

    static void Merge(int[] arr, int[] temp, int left, int mid, int right)
    {
        int low = left;
        int high = mid + 1;
        int index = left;

        while (low <= mid && high <= right)
        {
            temp[index++] = arr[low] < arr[high] ? arr[low++] : arr[high++];
        }

        while (low <= mid)
        {
            temp[index++] = arr[low++];
        }

        while (high <= right)
        {
            temp[index++] = arr[high++];
        }

        for (int i = left; i <= right; ++i)
        {
            count++;
            arr[i] = temp[i];
            if (count == order)
            {
                SW.WriteLine(arr[i]);
                return;
            }
        }
    }
}