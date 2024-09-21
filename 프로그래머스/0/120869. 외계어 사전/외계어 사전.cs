using System;

public class Solution
{
    public int solution(string[] spell, string[] dic)
    {
        int answer = 2;
        
        foreach (string str in dic)
        {
            if (IsValid(spell, str))
            {
                answer = 1;
                break;
            }
        }
        
        return answer;
    }
    
    public bool IsValid(string[] spell, string str)
    {
        foreach (string sp in spell)
        {
            if (!str.Contains(sp))
            {
                return false;
            }
        }
        return true;
    }
}