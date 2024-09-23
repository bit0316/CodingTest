using System;
using System.Linq;

public class Solution
{
    public int solution(int[] num_list, int n)
    {
        int answer = num_list.Contains(n) ? 1 : 0;
        
        return answer;
    }
}