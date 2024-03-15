public class Program
{
    static void Main(string[] args)
    {
        int num = 666;
        int count = 1;
        int input;
        
        input= int.Parse(Console.ReadLine());

        while (count < input)
        {
            num++;
            if (num.ToString().Contains("666"))
            {
                count++;
            }
        }
        Console.WriteLine(num);
    }
}