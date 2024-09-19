using System;

public class Solution
{
    public string[] solution(string my_str, int n)
    {
        int size = my_str.Length;
        int count = size % n > 0 ? size / n + 1 : size / n;
        string[] answer = new string[count];
        int index = 0;
        
        for (int i = 0; i < size - n; i += n)
        {
            answer[index++] = my_str.Substring(i, n);
        }
        if (index < count)
        {
            answer[index] = my_str.Substring(index * n);
        }
        
        return answer;
    }
}