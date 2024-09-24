using System;
using System.Linq;

public class Solution
{
    public int solution(string before, string after)
    {
        char[] arrA = before.ToArray();
        char[] arrB = after.ToArray();
        int answer = 0;
        
        Array.Sort(arrA);
        Array.Sort(arrB);
        answer = IsValid(arrA, arrB) ? 1 : 0;
        
        return answer;
    }
    
    public bool IsValid(char[] strA, char[] strB)
    {
        int size = strA.Length;
        
        for (int i = 0; i < size; ++i)
        {
            if (strA[i] != strB[i])
            {
                return false;
            }
        }
        return true;
    }
}