public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        int size;
        int count;
        int result;
        string text;

        size = int.Parse(SR.ReadLine());
        text = SR.ReadLine();

        list.Add(0);
        count = 1;
        for (int i = 1; i < size; ++i)
        {
            if (text[i - 1] == text[i])
            {
                count++;
            }
            else
            {
                list.Add(count);
                count = 1;
            }
        }
        list.Add(count);

        result = 0;
        for (int i = 1; i < list.Count; ++i)
        {
            result = Math.Max(result, Math.Min(list[i - 1], list[i]));
        }

        SW.WriteLine(result * 2);

        SR.Close();
        SW.Close();
    }
}