using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        List<int> best = new List<int>();
        int[] solutionsA = new int[] { 1, 2, 3, 4, 5 };
        int[] solutionsB = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] solutionsC = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int[] count = new int[3];
        int[] answer;
        int max;
        
        count[0] = GetCount(answers, solutionsA);
        count[1] = GetCount(answers, solutionsB);
        count[2] = GetCount(answers, solutionsC);
        max = count.Max();
        
        for (int i = 0; i < 3; ++i)
        {
            if (count[i] == max)
            {
                best.Add(i + 1);
            }
        }
        answer = best.ToArray();
        
        return answer;
    }
    
    public int GetCount(int[] answers, int[] solutions)
    {
        int sizeAnswer = answers.Length;
        int sizeSolution = solutions.Length;
        int count = 0;
        
        for (int i = 0; i < sizeAnswer; ++i)
        {
            if (answers[i] == solutions[i % sizeSolution])
            {
                count++;
            }
        }
        
        return count;
    }
}