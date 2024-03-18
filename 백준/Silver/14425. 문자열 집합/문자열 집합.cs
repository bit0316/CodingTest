using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int sizeA;
        int sizeB;
        string[] input;
        string[] arrTexts;
        HashSet<string> hashTexts = new HashSet<string>();

        input = sr.ReadLine().Split();
        sizeA = int.Parse(input[0]);
        sizeB = int.Parse(input[1]);
        arrTexts = new string[sizeB];

        SetTexts(hashTexts, sizeA);
        SetTexts(arrTexts, sizeB);
        PrintResult(hashTexts, arrTexts);

        sr.Close();
        sw.Close();
    }

    static void SetTexts(HashSet<string> texts, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            texts.Add(sr.ReadLine());
        }
    }

    static void SetTexts(string[] texts, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            texts[i] = sr.ReadLine();
        }
    }

    static void PrintResult(HashSet<string> hashTexts, string[] arrTexts)
    {
        int count = 0;
        int size = arrTexts.Length;

        for (int i = 0; i < size; ++i)
        {
            if (hashTexts.Contains(arrTexts[i]))
            {
                count++;
            }
        }
        sw.WriteLine(count);

        sw.Flush();
    }
}