using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        HashSet<string> hash = new HashSet<string>(words);
        int size = words.Length;
        int[] answer = new int[2];
        string word;
        char end;
        
        word = words[0];
        hash.Remove(word);
        end = word[word.Length - 1];
        for (int i = 1; i < size; ++i)
        {
            word = words[i];
            if (end != word[0] || !hash.Contains(word))
            {
                answer[0] = (i + 1) % n;
                if (answer[0] == 0)
                {
                    answer[0] = n;
                }
                answer[1] = i / n + 1;
                break;
            }
            
            hash.Remove(word);
            end = word[word.Length - 1];
        }
        
        return answer;
    }
}