using System;

public class Solution
{
    public int max = 0;
    
    public int solution(int k, int[,] dungeons)
    {
        int size = dungeons.GetLength(0);
        bool[] visited = new bool[size];
        
        DFS(0, k, size, dungeons, visited);
        
        return max;
    }
    
    public void DFS(int count, int energy, int size, int[,] dungeons, bool[] visited)
    {
        max = Math.Max(max, count);
        
        for (int i = 0; i < size; ++i)
        {
            if (!visited[i] && energy >= dungeons[i, 0])
            {
                visited[i] = true;
                DFS(count + 1, energy - dungeons[i, 1], size, dungeons, visited);
                visited[i] = false;
            }
        }
    }
}