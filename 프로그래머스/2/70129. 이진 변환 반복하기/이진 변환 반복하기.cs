using System;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[2];
        
        while (s != "1")
        {
            foreach(char ch in s)
            {
                if (ch == '0')
                {
                    answer[1]++;
                }
            }
            
            s = Convert.ToString(s.Replace("0", "").Length, 2);
            answer[0]++;
        }
        
        return answer;
    }
}