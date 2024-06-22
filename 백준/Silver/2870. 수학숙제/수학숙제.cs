public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        string strNum;
        string input;

        for (int i = 0; i < size; ++i)
        {
            strNum = "";
            input = SR.ReadLine();
            for (int j = 0; j < input.Length; ++j)
            {
                if (input[j] >= '0' && input[j] <= '9')
                {
                    strNum += input[j];
                }
                else if (strNum != "")
                {
                    strNum = RemovefrontZero(strNum);
                    dict[strNum] = dict.GetValueOrDefault(strNum) + 1;
                    strNum = "";
                }
            }
            if (strNum != "")
            {
                strNum = RemovefrontZero(strNum);
                dict[strNum] = dict.GetValueOrDefault(strNum) + 1;
            }
        }
    }

    static string RemovefrontZero(string strNum)
    {
        int size = strNum.Length;

        for (int i = 0; i < size; ++i)
        {
            if (strNum[i] != '0')
            {
                return strNum[i..];
            }
        }

        return "0";
    }

    static void PrintResult()
    {
        foreach (var pair in dict.OrderBy(x => x.Key.Length))
        {
            for (int i = pair.Value; i > 0; --i)
            {
                SW.WriteLine(pair.Key);
            }
        }
    }
}