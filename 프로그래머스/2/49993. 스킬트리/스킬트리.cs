using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string skill, string[] skill_trees)
    {
        HashSet<char> hash = new HashSet<char>();
        int answer = 0;
        
        foreach (string tree in skill_trees)
        {
            if (IsValid(skill, tree))
            {
                answer++;
            }
        }
        
        return answer;
    }
    
    public bool IsValid(string skill, string tree)
    {
        bool isStop = false;
        int pos = -1;
        int index;
        
        foreach (char ch in skill)
        {
            index = tree.IndexOf(ch);
            if (index == -1)
            {
                isStop = true;
                continue;
            }
            if (pos < index && !isStop)
            {
                pos = index;
                continue;
            }
            return false;
        }
        return true;
    }
}