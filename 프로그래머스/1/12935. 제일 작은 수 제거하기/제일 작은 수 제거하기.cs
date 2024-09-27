using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> list = arr.ToList();
        int[] answer = new int[] { -1 };
        
        if (list.Count > 1)
        {
            list.Remove(list.Min());
            answer = list.ToArray();
        }
        
        return answer;
    }
}