public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int SIZE_MIN = 2;
    const int SIZE_MAX = 3;

    static void Main(string[] args)
    {
        int[] arrF = new int[SIZE_MAX];
        int[] arrG = new int[SIZE_MIN];
        string result;

        arrF = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        arrG = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult(arrF, arrG);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }


    static string GetResult(int[] arrF, int[] arrG)
    {
        if (arrF[0] == 0 && arrF[1] == arrG[0] && arrF[2] == arrG[1])
        {
            return "Nice";
        }

        int[] arrP = new int[SIZE_MAX];
        int[] arrQ = new int[SIZE_MAX];
        int[] result = new int[SIZE_MAX];
        int contact;

        arrP[0] = arrG[0] * arrF[0];
        arrP[1] = arrG[0] * arrF[1];
        arrP[2] = arrG[0] * arrF[2] + arrG[1];

        arrQ[0] = arrG[0] * arrG[0] * arrF[0];
        arrQ[1] = 2 * arrG[0] * arrG[1] * arrF[0] + arrG[0] * arrF[1];
        arrQ[2] = arrG[1] * arrG[1] * arrF[0] + arrG[1] * arrF[1] + arrF[2];

        for (int i = 0; i < 3; i++)
        {
            result[i] = arrP[i] - arrQ[i];
        }

        contact = result[1] * result[1] - 4 * result[0] * result[2];
        if (contact < 0 || (result[0] == 0 && result[1] == 0))
        {
            return "Head on";
        }
        else if (contact == 0 || (result[0] == 0 && result[1] != 0))
        {
            return "Remember my character";
        }
        else
        {
            return "Go ahead";
        }
    }

    static void PrintResult(string result)
    {
        SW.WriteLine(result);
    }
}