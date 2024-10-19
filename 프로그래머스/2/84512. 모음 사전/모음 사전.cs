using System;
using System.Collections.Generic;

public class Solution
{
    public const int MAX_LENGTH = 5;
    public Dictionary<char, int> DICT = new Dictionary<char, int>
    {
        { 'A', 0 }, { 'E', 1 }, { 'I', 2 }, { 'O', 3 }, { 'U', 4 }
    };
    
    public int solution(string word)
    {
        int[] count = new int[MAX_LENGTH + 1];
        int size = word.Length;
        int answer = 0;
        
        for (int i = 1; i <= MAX_LENGTH; ++i)
        {
            count[i] = (int)Math.Pow(MAX_LENGTH, i - 1) + count[i - 1];
        }
        
        for (int i = 0; i < size; ++i)
        {
            answer += DICT[word[i]] * count[MAX_LENGTH - i] + 1;
        }
        
        return answer;
    }
}