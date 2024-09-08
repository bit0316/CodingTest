using System;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        string answer = "";
        int size = queries.Length / 2;
        char[] arr = my_string.ToCharArray();
        char temp;
        int count;
        
        for (int i = 0; i < size; ++i)
        {
            Array.Reverse(arr, queries[i, 0], queries[i, 1] - queries[i, 0] + 1);
        }
        answer = new string(arr);
        
        return answer;
    }
}