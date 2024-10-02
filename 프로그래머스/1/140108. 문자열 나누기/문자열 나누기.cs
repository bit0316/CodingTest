using System;

public class Solution
{
    public int solution(string s)
    {
        int size = s.Length;
        int answer = 0;
        int index = 0;
        int countA = 0;
        int countB = 0;
        char ch = s[index];
        
        while (index + countA + countB < size)
        {
            if (s[index + countA + countB] == ch)
            {
                countA++;
            }
            else
            {
                countB++;
            }
            
            if (countA == countB)
            {
                answer++;
                index += countA + countB;
                if (index < size)
                {
                    ch = s[index];
                    countA = 0;
                    countB = 0;
                }
            }
        }
        if (index < size)
        {
            answer++;
        }
        
        return answer;
    }
}