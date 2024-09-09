using System;
using System.Collections.Generic;

public class Solution
{
    public Dictionary<string, char> morse = new Dictionary<string, char>()
    {
        {".-", 'a'}, {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'}, {".", 'e'}, {"..-.", 'f'},
        {"--.", 'g'}, {"....", 'h'}, {"..", 'i'}, {".---", 'j'}, {"-.-", 'k'}, {".-..", 'l'},
        {"--", 'm'}, {"-.", 'n'}, {"---", 'o'}, {".--.", 'p'}, {"--.-", 'q'}, {".-.", 'r'},
        {"...", 's'}, {"-", 't'}, {"..-", 'u'}, {"...-", 'v'}, {".--", 'w'}, {"-..-", 'x'},
        {"-.--", 'y'}, {"--..", 'z'}
    };
    
    public string solution(string letter)
    {
        string answer = "";
        string[] arr = letter.Split();
        int size = arr.Length;
        
        for (int i = 0; i < size; ++i)
        {
            answer += morse[arr[i]];
        }
        
        return answer;
    }
}