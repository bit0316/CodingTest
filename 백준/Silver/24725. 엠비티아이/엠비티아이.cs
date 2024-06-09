using System;

public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int row;
    static int col;
    static int count;
    static int[] input;
    static (int, int)[] direction = { (0, 1), (1, -1), (1, 0), (1, 1) };
    static char[][] arr;
    static (char, char)[] mbti = { ('E', 'I'), ('N', 'S'), ('F', 'T'), ('P', 'J') };

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        row = input[0];
        col = input[1];

        SetArray();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new char[row][];
        for (int i = 0; i < row; ++i)
        {
            arr[i] = SR.ReadLine().ToCharArray();
        }
    }

    static void GetResult()
    {

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (arr[i][j] == mbti[0].Item1 || arr[i][j] == mbti[0].Item2)
                {
                    foreach (var dir in direction)
                    {
                        CheckMBTI(i - dir.Item1, j - dir.Item2, -dir.Item1, -dir.Item2, 1);
                        CheckMBTI(i + dir.Item1, j + dir.Item2, dir.Item1, dir.Item2, 1);
                    }
                }
            }
        }
    }

    static void CheckMBTI(int posX, int posY, int dirX, int dirY, int index)
    {
        if (index == 4)
        {
            count++;
            return;
        }

        if (posX < 0 || posX >= row || posY < 0 || posY >= col)
        {
            return;
        }

        if (arr[posX][posY] == mbti[index].Item1 || arr[posX][posY] == mbti[index].Item2)
        {
            CheckMBTI(posX + dirX, posY + dirY, dirX, dirY, index + 1);
        }
    }

    static void PrintResult()
    {
        SW.WriteLine(count);
    }
}