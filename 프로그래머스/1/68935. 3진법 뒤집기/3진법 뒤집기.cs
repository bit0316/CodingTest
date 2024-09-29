using System;

public class Solution
{
    public int solution(int n)
    {
        string str = "";
        int answer = 0;
        int size;
        
        while (n > 0)
        {
            str += (n % 3).ToString();
            n /= 3;
        }
        
        size = str.Length;
        for (int i = size - 1; i >= 0; --i)
        {
            answer += int.Parse(str[i].ToString()) * (int)Math.Pow(3, size - i - 1);
        }
        
        return answer;
    }
}