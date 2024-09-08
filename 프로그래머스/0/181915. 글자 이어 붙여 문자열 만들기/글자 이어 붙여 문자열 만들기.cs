using System;

public class Solution
{
    public string solution(string my_string, int[] index_list)
    {
        string answer = "";
        int size = index_list.Length;
        
        for (int i = 0; i < size; ++i)
        {
            answer += my_string[index_list[i]];
        }
        
        return answer;
    }
}