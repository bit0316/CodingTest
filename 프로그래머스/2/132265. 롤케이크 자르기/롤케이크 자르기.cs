using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] topping)
    {
        Dictionary<int, int> dictA = new Dictionary<int, int>();
        Dictionary<int, int> dictB = new Dictionary<int, int>();
        int size = topping.Length;
        int answer = 0;
        int countA = 0;
        int countB = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (!dictA.ContainsKey(topping[i]))
            {
                dictA.Add(topping[i], 0);
                countA++;
            }
            dictA[topping[i]]++;
        }
        
        for (int i = 0; i < size; ++i)
        {
            dictA[topping[i]]--;
            if (!dictB.ContainsKey(topping[i]))
            {
                dictB.Add(topping[i], 0);
                countB++;
            }
            dictB[topping[i]]++;
            
            if (dictA[topping[i]] == 0)
            {
                countA--;
            }
            if (countA == countB)
            {
                answer++;
            }
        }
        
        return answer;
    }
}