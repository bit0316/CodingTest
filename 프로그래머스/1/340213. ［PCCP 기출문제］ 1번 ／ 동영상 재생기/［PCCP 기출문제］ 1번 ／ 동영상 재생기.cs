using System;

public class Solution
{
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
    {
        int move = 10;
        int size = commands.Length;
        int[] videoTime = Array.ConvertAll(video_len.Split(':'), int.Parse);
        int[] posTime = Array.ConvertAll(pos.Split(':'), int.Parse);
        int[] opStartTime = Array.ConvertAll(op_start.Split(':'), int.Parse);
        int[] opEndTime = Array.ConvertAll(op_end.Split(':'), int.Parse);
        string answer = "";
        
        posTime = CalculateOpTime(posTime, opStartTime, opEndTime);
        for (int i = 0; i < size; ++i)
        {
            posTime = CalculateCommandTime(posTime, commands[i], move);
            posTime = CalculateOpTime(posTime, opStartTime, opEndTime);
            posTime = CalculatevideoTime(posTime, videoTime);
        }
        answer += posTime[0].ToString("D2") + ":" + posTime[1].ToString("D2");
        
        return answer;
    }
    
    public int[] CalculateCommandTime(int[] posTime, string command, int move)
    {
        posTime[1] += command == "next" ? move : -move;
        if (posTime[1] >= 60)
        {
            posTime[0] += posTime[1] / 60;
            posTime[1] %= 60;
        }
        else if (posTime[1] < 0)
        {
            posTime[0] += posTime[1] / 60 - 1;
            posTime[1] = posTime[1] % 60 + 60;
        }
        if (posTime[0] < 0)
        {
            posTime[0] = 0;
            posTime[1] = 0;
        }
        return posTime;
    }
    
    public int[] CalculateOpTime(int[] posTime, int[] opStartTime, int[] opEndTime)
    {
        if ((posTime[0] > opStartTime[0] ||
             posTime[0] == opStartTime[0] && posTime[1] >= opStartTime[1]) &&
            (posTime[0] < opEndTime[0] ||
             posTime[0] == opEndTime[0] && posTime[1] <= opEndTime[1]))
        {
            posTime[0] = opEndTime[0];
            posTime[1] = opEndTime[1];
        }
        return posTime;
    }
    
    public int[] CalculatevideoTime(int[] posTime, int[] videoTime)
    {
        if (posTime[0] > videoTime[0])
        {
            posTime[0] = videoTime[0];
            posTime[1] = videoTime[1];
        }
        else if (posTime[0] == videoTime[0] && posTime[1] >= videoTime[1])
        {
            posTime[1] = videoTime[1];
        }
        return posTime;
    }
}