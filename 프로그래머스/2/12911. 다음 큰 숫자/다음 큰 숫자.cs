using System;

class Solution 
{
    public int solution(int n) 
    {
        int answer = n;
        string strA, strB;
        int countA, countB;
        
        strA = Convert.ToString(n, 2);
        countA = GetOneCount(strA);
        
        while (true)
        {
            answer++;
            strB = Convert.ToString(answer, 2);
            countB = GetOneCount(strB);
            if (countA == countB)
            {
                break;
            }
        }
        
        return answer;
    }
    
    public int GetOneCount(string str)
    {
        int count = 0;
        
        foreach (char ch in str)
        {
            if (ch == '1')
            {
                count++;
            }
        }
        
        return count;
    }
}