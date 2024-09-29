using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int size = commands.GetLength(0);
        int[] answer = new int[size];
        int start, end, index, length;
        int[] arr;
        
        for (int i = 0; i < size; ++i)
        {
            arr = array.Skip(commands[i, 0] - 1).Take(commands[i, 1] - commands[i, 0] + 1).ToArray();
            Array.Sort(arr);
            answer[i] = arr[commands[i, 2] - 1];
        }
        
        return answer;
    }
}