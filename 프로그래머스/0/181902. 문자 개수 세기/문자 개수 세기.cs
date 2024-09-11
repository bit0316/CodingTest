using System;

public class Solution
{
    public int[] solution(string my_string)
    {
        int alphabet = 26;
        int size = my_string.Length;
        int[] answer = new int[alphabet * 2];
        
        for (int i = 0; i < size; ++i)
        {
            if (char.IsUpper(my_string[i]))
            {
                answer[my_string[i] - 'A']++;
            }
            else
            {
                answer[alphabet + my_string[i] - 'a']++;
            }
        }
        
        return answer;
    }
}