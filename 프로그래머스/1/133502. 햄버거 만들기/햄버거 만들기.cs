using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] ingredient)
    {
        List<int> list = new List<int>();
        int[] burger = { 1, 2, 3, 1 };
        int burgerSize = burger.Length;
        int size = ingredient.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            list.Add(ingredient[i]);
            if (IsValid(list, burger))
            {
                list.RemoveRange(list.Count - burgerSize, burgerSize);
                answer++;
            }
        }
        
        return answer;
    }
    
    public bool IsValid(List<int> list, int[] burger)
    {
        if (list.Count < burger.Length)
        {
            return false;
        }
        
        int burgerSize = burger.Length;
        int count = list.Count;
        
        for (int j = 0; j < burgerSize; ++j)
        {
            if (list[count - burgerSize + j] != burger[j])
            {
                return false;
            }
        }
        return true;
    }
}