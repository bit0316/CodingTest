using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] players, string[] callings)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int size = players.Length;
        string[] answer = players;
        int rank;
        
        for (int i = 0; i < size; ++i)
        {
            dict.Add(players[i], i);
        }
        
        foreach (string name in callings)
        {
            rank = dict[name];
            answer[rank] = answer[rank - 1];
            answer[rank - 1] = name;
            
            dict[name]--;
            dict[answer[rank]]++;
        }
        
        return answer;
    }
}