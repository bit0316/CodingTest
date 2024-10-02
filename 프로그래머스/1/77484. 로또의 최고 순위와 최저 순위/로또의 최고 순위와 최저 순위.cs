using System;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] answer = new int[2];
        int size = lottos.Length;
        int correct = 0;
        int zero = 0;
        
        foreach (int pick in lottos)
        {
            if (pick == 0)
            {
                zero++;
                continue;
            }
            
            foreach (int win in win_nums)
            {
                if (pick == win)
                {
                    correct++;
                    break;
                }
            }
        }
        
        answer[0] = correct + zero > 1 ? size - (correct + zero) + 1 : 6;
        answer[1] = correct > 1 ? size - correct + 1 : 6;
        
        return answer;
    }
}