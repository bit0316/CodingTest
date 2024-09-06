using System;

public class Solution
{
    public string solution(int[] numLog)
    {
        string answer = "";
        int size = numLog.Length;
        
        for (int i = 1; i < size; ++i)
        {
            switch(numLog[i] - numLog[i - 1])
            {
                case 1:
                    answer += 'w';
                    break;
                case -1:
                    answer += 's';
                    break;
                case 10:
                    answer += 'd';
                    break;
                case -10:
                    answer += 'a';
                    break;
            }
        }        
        
        return answer;
    }
}