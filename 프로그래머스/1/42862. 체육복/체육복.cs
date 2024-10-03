using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        List<int> lostList = new List<int>(lost);
        bool[] canBorrow = new bool[n + 2];
        int answer = n - lost.Length;
        
        foreach (int index in reserve)
        {
            if (lostList.Contains(index))
            {
                lostList.Remove(index);
                answer++;
                continue;
            }
            canBorrow[index] = true;
        }
        
        lostList.Sort();
        foreach (int index in lostList)
        {
            if (canBorrow[index])
            {
                canBorrow[index] = false;
                answer++;
            }
            else if (canBorrow[index - 1])
            {
                canBorrow[index - 1] = false;
                answer++;
            }
            else if (canBorrow[index + 1])
            {
                canBorrow[index + 1] = false;
                answer++;
            }
        }
        
        return answer;
    }
}