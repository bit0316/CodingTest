using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] rank, bool[] attendance)
    {
        List<(int, int)> list = new List<(int, int)>();
        int size = rank.Length;
        int answer = 0;

        for (int i = 0; i < size; ++i)
        {
            if (attendance[i])
            {
                list.Add((rank[i], i));
            }
        }
        
        list = list.OrderBy(x => x.Item1).ToList();
        answer += 10000 * list[0].Item2;
        answer += 100 * list[1].Item2;
        answer += 1 * list[2].Item2;
        
        return answer;
    }
}