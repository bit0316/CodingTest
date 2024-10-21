using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    const string lastTime = "23:59";
    
    public int[] solution(int[] fees, string[] records)
    {
        Dictionary<string, string> cars = new Dictionary<string, string>();
        Dictionary<string, int> times = new Dictionary<string, int>();
        List<string> numbers = new List<string>();
        int[] answer;
        string[] arr;
        int count;
        double over;
        
        foreach (string record in records)
        {
            arr = record.Split();
            if (arr[2] == "IN")
            {
                cars[arr[1]] = arr[0];
                times.TryAdd(arr[1], 0);
                numbers.Add(arr[1]);
                continue;
            }
            
            times[arr[1]] += GetTime(cars[arr[1]], arr[0]);
            cars.Remove(arr[1]);
        }
        
        foreach (string number in cars.Keys)
        {
            times[number] += GetTime(cars[number], lastTime);
        }
        
        numbers = times.Keys.ToList();
        numbers.Sort();
        
        count = numbers.Count;
        answer = new int[count];
        for (int i = 0; i < count; ++i)
        {
            answer[i] = fees[1];
            over = times[numbers[i]] - fees[0];
            if (over > 0)
            {
                answer[i] += (int)Math.Ceiling(over / fees[2]) * fees[3];
            }
        }
        
        return answer;
    }
    
    public int GetTime(string timeIn, string timeOut)
    {
        int[] timeA = Array.ConvertAll(timeIn.Split(':'), int.Parse);
        int[] timeB = Array.ConvertAll(timeOut.Split(':'), int.Parse);
        
        return (timeB[0] - timeA[0]) * 60 + (timeB[1] - timeA[1]);
    }
}