using System;

public class Solution
{
    public int[] solution(string[] keyinput, int[] board)
    {
        int sizeX = board[0] / 2;
        int sizeY = board[1] / 2;
        int[] answer = new int[] { 0, 0 };
        
        foreach (string dir in keyinput)
        {
            if (dir == "left" && answer[0] > -sizeX)
            {
                answer[0]--;
            }
            if (dir == "right" && answer[0] < sizeX)
            {
                answer[0]++;
            }
            if (dir == "down" && answer[1] > -sizeY)
            {
                answer[1]--;
            }
            if (dir == "up" && answer[1] < sizeY)
            {
                answer[1]++;
            }
        }
        
        return answer;
    }
}