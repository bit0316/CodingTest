using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        Queue<int> queue = new Queue<int>();
        int size = truck_weights.Length;
        int[] arr = new int[size];
        int answer = bridge_length;
        int total = 0;
        int index = 0;
        int time;
        
        while (index < size)
        {
            if (queue.Count > 0 && arr[queue.Peek()] == bridge_length)
            {
                total -= truck_weights[queue.Dequeue()];
            }
            
            if (total + truck_weights[index] <= weight)
            {
                answer++;
                queue.Enqueue(index);
                foreach (int truck in queue)
                {
                    arr[truck]++;
                }
                total += truck_weights[index];
                index++;
                continue;
            }

            time = bridge_length - arr[queue.Peek()];
            answer += time;
            foreach (int truck in queue)
            {
                arr[truck] += time;
            }
            total -= truck_weights[queue.Dequeue()];
        }
        
        return answer;
    }
}